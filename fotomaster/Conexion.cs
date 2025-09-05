using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace fotomaster
{
    public class Conexion
    {
        private static string cadena = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
