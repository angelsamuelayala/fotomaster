using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotomaster
{
    public class DetalleVentaTemp
    {
        public int idServicio { get; set; }
        public int idFormato { get; set; }
        public int idCalidad { get; set; }
        public int cantidad { get; set; }
        public byte[] fotobinario { get; set; }

        public string Servicio { get; set; }
        public string Formato { get; set; }
        public string Calidad { get; set; }
       
    }
}
