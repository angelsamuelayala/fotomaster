using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotomaster
{
    public class Descuento
    {
        // Carpeta base del programa (igual que en Sucursal)
        private static string carpetaBase = @"C:\fotoestudiomaster\fotomaster";

        // Nombre del archivo donde se guardará el descuento
        private static string archivoDescuento = Path.Combine(carpetaBase, "descuento.txt");

        // Guardar el descuento en el archivo
        public static void GuardarDescuento(decimal valorDescuento)
        {
            try
            {
                // Crear carpeta si no existe
                if (!Directory.Exists(carpetaBase))
                    Directory.CreateDirectory(carpetaBase);

                File.WriteAllText(archivoDescuento, valorDescuento.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el descuento: " + ex.Message);
            }
        }

        // Recuperar el descuento del archivo
        public static decimal CargarDescuento()
        {
            try
            {
                if (!File.Exists(archivoDescuento))
                    return 0; // Si no existe, retorna 0 como valor por defecto

                string contenido = File.ReadAllText(archivoDescuento);
                if (decimal.TryParse(contenido, out decimal valorDescuento))
                    return valorDescuento;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el descuento: " + ex.Message);
            }
        }
    }
}
