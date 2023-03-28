using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTijera
{
    public class Papel
    {
        public string Tipo { get; set; } = "";

        public string Jugar(Papel jugar)
        {
            string? mensaje;
            if ("piedra" == jugar.Tipo)
            {
                mensaje = "gano";
            }
            else if ("papel" == jugar.Tipo)
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
