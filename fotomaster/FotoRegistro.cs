using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotomaster
{
    public class FotoRegistro
    {
        public int IdFoto { get; set; }
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] FotoBytes { get; set; }
        public double[] Embedding { get; set; }
        public double Distancia { get; set; }
    }
}
