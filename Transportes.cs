using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Transportes
    {
        public string destinatario { get; set; }
        public string destino { get; set; }
        public int tarifa { get; set; }
        public double toneladas { get; set; }


        public Transportes() 
        {
            tarifa = 0;
            toneladas = 0;
        }
        
        public double calcularFlete()
        {
            return tarifa * toneladas;
        }
    }
}
