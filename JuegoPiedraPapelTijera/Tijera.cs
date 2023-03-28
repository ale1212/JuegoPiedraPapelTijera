using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTijera
{
    public class Tijera
    {
        public string Tipo { get; set; } = "";

        public string Jugar(Tijera jugar)
        {
            string? mensaje;
            if ("papel" == jugar.Tipo)
            {
                mensaje = "gano";
            }
            else if ("tijera" == jugar.Tipo)
            {
                mensaje = "empato";
            }
            else
            {

                mensaje = "perdio";

            }
            return mensaje;
        }
    }
}
