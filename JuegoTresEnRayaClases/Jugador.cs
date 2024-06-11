using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresEnRayaClases
{
    public class Jugador
    {
        public string nombre;
        public char simbolo;

        public Jugador(string nombre, char simbolo)
        {
            this.nombre = nombre;
            this.simbolo = simbolo;
        }
    }
}
