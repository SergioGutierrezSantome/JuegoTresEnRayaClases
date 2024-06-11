using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresEnRayaClases
{
    public class Tabla
    {
        public char[,] board;
        public int size;
        public Tabla(int size = 3)
        {
            this.size = size;
            board = new char[size, size];
            InicializarJuego();
        }
        public void InicializarJuego()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }
        public bool ComprobarGanador(char simbol)
        {
            for (int i = 0; i < size; i++)
            {
                if (ComprobarFila(i, simbol) || ComprobarColumna(i, simbol))
                    return true;
            }

            return ComprobarDiagonal(simbol) || Comprobarvertical(simbol);
        }
        public Boolean Comprobarvertical(char simbol)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[i, size - i - 1] != simbol)
                    return false;
            }
            return true;
        }
        public Boolean ComprobarDiagonal(char simbol)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[i, i] != simbol)
                    return false;
            }
            return true;
        }
        public Boolean ComprobarColumna(int column, char simbol)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[i,column] != simbol)
                    return false;
            }
            return true;
        }
        public Boolean ComprobarFila(int file, char simbol)
        {
            for (int i = 0; i < size; i++)
            {
                if (board[file, i] != simbol)
                    return false;
            }
            return true;
        }
        public Boolean AñadirSimbolo(int row,int column ,char simbol)
        {
            if (row>=0 && row<size && column >= 0 && column < size && board[row, column] ==' ')
            {

                board[row, column] = simbol;
                return true;

            }
            return false;
        }
        public Boolean ComprobarEmpate()
        {
            for (int i = 0; i < size; i++)
            {
                for (int a = 0; a < size; a++)
                {
                    if(board[i, a] == ' ')
                        return false;
                }
            }
            return true;
        }
        public void DibujarTablero()
        {
            for (int fila = 0; fila < size; fila++)
            {
                for (int columna = 0; columna < size; columna++)
                {
                    Console.Write(board[fila, columna]);
                    if (columna < size - 1)
                         Console.Write("|");
                    
                }
                Console.WriteLine();
                if (fila < size - 1)
                     Console.WriteLine("-------");
                

            }
        }
    }
}
