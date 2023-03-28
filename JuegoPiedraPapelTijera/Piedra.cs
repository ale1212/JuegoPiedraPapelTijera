using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTijera
{
    public class Piedra
    {
        public string Tipo { get; set; } = "";

        public string Jugar(string jugar)
        {
            string? mensaje;
            if ("tijera" == jugar)
            {
                mensaje = "gano";
            }else if ("piedra" == jugar)  
            {
                mensaje = "empato";
            }
            else {

                    mensaje = "perdio";

             }
            return mensaje; 
        }

    }
}
