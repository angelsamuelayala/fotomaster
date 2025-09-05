using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotomaster
{
    public class Sucursal
    {
        // Carpeta base del programa
        private static string carpetaBase = @"C:\fotoestudiomaster\fotomaster";

        // Nombre del archivo donde se guardará la sucursal
        private static string archivoSucursal = Path.Combine(carpetaBase, "sucursal.txt");

        // Guardar el idSucursal en el archivo
        public static void GuardarSucursal(int idSucursal)
        {
            try
            {
                // Crear carpeta si no existe
                if (!Directory.Exists(carpetaBase))
                    Directory.CreateDirectory(carpetaBase);

                File.WriteAllText(archivoSucursal, idSucursal.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la sucursal: " + ex.Message);
            }
        }

        // Recuperar el idSucursal del archivo
        public static int CargarSucursal()
        {
            try
            {
                if (!File.Exists(archivoSucursal))
                    return 0; // Si no existe, retorna 0 o valor por defecto

                string contenido = File.ReadAllText(archivoSucursal);
                if (int.TryParse(contenido, out int idSucursal))
                    return idSucursal;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la sucursal: " + ex.Message);
            }
        }
    }
}
