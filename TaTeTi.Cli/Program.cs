using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaTeTi.Xml;

namespace TaTeTi.Cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            int turn = 0;

            while (turn < 9)
            {
                Console.WriteLine(board.ToString());
                int x, y;

                SquareValue squareValue = turn % 2 == 0 ? SquareValue.X : SquareValue.O;
                try
                {
                    Console.Write("Introduzca fila: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduzca columna: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    board.Set(x, y, squareValue);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto...");
                    Console.ReadLine();
                    continue;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Posicion incorrecta...");
                    Console.ReadLine();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    continue;
                }

                if (turn % 2 == 0)
                    if (board.WinX())
                    {
                        Console.WriteLine("Gana X");
                        Console.WriteLine(board.ToString());
                        Console.ReadLine();
                        return;
                    }

                if (turn % 2 == 0)
                    if (board.WinO())
                    {
                        Console.WriteLine("Gana O");
                        Console.WriteLine(board.ToString());
                        Console.ReadLine();
                        return;
                    }

                if (turn == 9)
                {
                    Console.WriteLine("No hay ganador");
                    Console.WriteLine(board.ToString());
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine(XmlSudaca.Serialize<Board>(board));

                turn++;
            }
        }
    }
}
