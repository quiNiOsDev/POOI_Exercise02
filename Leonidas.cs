using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Leonidas :Transportes
    {
        public double calcularTarifario()
        {
            switch (destino.ToLower()) 
            {
                case "arequipa":
                case "ilo":
                case "tacna": tarifa = 200;break;
                case "cajamarca":
                case "piura":
                case "tumbes": tarifa = 220;break;
                default: tarifa = 150;break;

            }
            return tarifa;

        }

       public double calcularSeguro() 
        {
            return 0.05 * calcularFlete();
        }

        public double calcularMonto()
        {
            return calcularSeguro() + calcularFlete();
        }
    }
}
