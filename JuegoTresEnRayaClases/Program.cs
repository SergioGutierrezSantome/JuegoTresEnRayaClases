using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresEnRayaClases
{
    internal class Program
    {
        static List<Jugador> listaJugador = new List<Jugador>();
        static List<Tabla> tablero = new List<Tabla>();
      
        static void Tresenraya()
        {
            Tabla tablero1 = new Tabla();

            int turno = 0;
            int row=20, col=20;
            bool FinPartida = false;
            while (!FinPartida)
            {
                Console.WriteLine("Turno para el jugador "+ listaJugador[turno].nombre+" Con simbolo "+ listaJugador[turno].simbolo);
                tablero1.DibujarTablero();
                while (col > 3 && row > 3)
                {
                    Console.WriteLine("Introduce el numero de columna: del 0 al 2");
                    col = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el numero de fila: 0 al 2");
                    row = int.Parse(Console.ReadLine());
                }
                if (tablero1.AñadirSimbolo(row, col, listaJugador[turno].simbolo))
                {
                    Console.WriteLine("Aplicada con exito");
                    if (tablero1.ComprobarGanador(listaJugador[turno].simbolo))
                    {
                        Console.WriteLine("El jugador "+ listaJugador[turno].nombre+" Gana la partida");
                        FinPartida = true;
                    }
                    if (tablero1.ComprobarEmpate())
                    {
                        Console.WriteLine("Empate!!!!!");
                        FinPartida = true;
                    }
                    turno = turno == 0 ? 1 : 0;
                }
                else
                {
                    Console.WriteLine("Casilla ocupada o no cabe");
                }
                col = 20;
                row = 20;
                Console.ReadKey();
                Console.Clear();
               
            }
        }
        static void Main(string[] args)
        {
            int opc = 0;
            while (opc == 0)
            {
                string Jugador1, Jugador2;
                Console.WriteLine("Nombre del jugador1: ");
                Jugador1 = Console.ReadLine();
                Console.WriteLine("Nombre del jugador2:");
                Jugador2 = Console.ReadLine();
                listaJugador.Add(new Jugador(Jugador1, 'X'));
                listaJugador.Add(new Jugador(Jugador2, 'O'));
                Tresenraya();
                listaJugador.Clear();
                Console.WriteLine("Volver a jugar??? introduce 0");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
