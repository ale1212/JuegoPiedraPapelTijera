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

        public string Jugar(string jugar)
        {
            string? mensaje;
            if ("papel" == jugar)
            {
                mensaje = "gano";
            }
            else if ("tijera" == jugar)
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
