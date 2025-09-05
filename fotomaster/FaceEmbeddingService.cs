using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Dnn;

namespace fotomaster
{
    internal class FaceEmbeddingService:IDisposable
    {
        private readonly CascadeClassifier _faceDetector;
        private readonly Net _faceRecognizer;
        private readonly string _modelsPath;

        /// <summary>
        /// Constructor: recibe la carpeta donde están los modelos .dat
        /// </summary>
        public FaceEmbeddingService(string modelsPath)
        {
            _modelsPath = modelsPath;
            string faceDetectorPath = Path.Combine(_modelsPath, "haarcascade_frontalface_default.xml");
            string faceRecognizerPath = Path.Combine(_modelsPath, "openface.nn4.small2.v1.t7");

            if (!File.Exists(faceDetectorPath) || !File.Exists(faceRecognizerPath))
            {
                throw new FileNotFoundException("No se encontraron los archivos de modelo (.xml o .t7) en la carpeta 'models'.");
            }

            _faceDetector = new CascadeClassifier(faceDetectorPath);
            _faceRecognizer = DnnInvoke.ReadNetFromTorch(faceRecognizerPath);
        }

        /// <summary>
        /// Obtiene el embedding (vector de 128 doubles) de la cara más prominente en un Bitmap.
        /// Retorna null si no detecta rostro.
        /// </summary>

        public double[] GetEncodingFromBitmap(Bitmap bmp)
        {
            if (bmp == null) return null;

            var image = bmp.ToImage<Bgr, byte>();
            var grayImage = image.Convert<Gray, byte>();

            var faces = _faceDetector.DetectMultiScale(grayImage, 1.1, 10, new Size(20, 20));

            if (faces.Length == 0) return null;
            var mainFace = faces.OrderByDescending(f => f.Width * f.Height).First();

            var faceImage = image.Copy(mainFace);
            var resizedFace = faceImage.Resize(96, 96, Emgu.CV.CvEnum.Inter.Cubic);

            var inputBlob = DnnInvoke.BlobFromImage(resizedFace, 1.0 / 255.0, new Size(96, 96), new MCvScalar(0, 0, 0), true, false);

            _faceRecognizer.SetInput(inputBlob);
            var embeddingMatrix = _faceRecognizer.Forward();

            var embedding = new double[128];
            var embeddingData = (float[,])embeddingMatrix.GetData();
            for (int i = 0; i < 128; i++)
            {
                embedding[i] = embeddingData[0, i];
            }

            return embedding;
        }

        /// <summary>
        /// Convierte un array de doubles a bytes (para guardar en BD)
        /// </summary>
        public static byte[] DoubleArrayToBytes(double[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            var bytes = new byte[arr.Length * sizeof(double)];
            Buffer.BlockCopy(arr, 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Convierte bytes a array de doubles (para leer de BD)
        /// </summary>
        public static double[] BytesToDoubleArray(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0 || bytes.Length % sizeof(double) != 0) return null;
            var arr = new double[bytes.Length / sizeof(double)];
            Buffer.BlockCopy(bytes, 0, arr, 0, bytes.Length);
            return arr;
        }

        /// <summary>
        /// Calcula la distancia euclidiana entre dos embeddings.
        /// </summary>
        public static double Euclidean(double[] v1, double[] v2)
        {
            if (v1 == null || v2 == null || v1.Length != v2.Length)
                throw new ArgumentException("Los vectores de embedding son inválidos.");

            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                double diff = v1[i] - v2[i];
                sum += diff * diff;
            }
            return Math.Sqrt(sum);
        }


        /// <summary>
        /// Liberar recursos
        /// </summary>
        public void Dispose()
        {
            _faceDetector?.Dispose();
            _faceRecognizer?.Dispose();
        }
    }
}
