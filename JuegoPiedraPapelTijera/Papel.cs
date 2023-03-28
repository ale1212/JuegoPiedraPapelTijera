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

        public string Jugar(string jugar)
        {
            string? mensaje;
            if ("piedra" == jugar)
            {
                mensaje = "gano";
            }
            else if ("papel" == jugar)
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
