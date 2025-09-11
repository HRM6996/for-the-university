using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrica = new int[100, 100];
            Console.WriteLine("sellect your color\n1-grean\n2-white\n3-red");
            int sellect_collor = Convert.ToInt32(Console.ReadLine());
            switch (sellect_collor)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.SetWindowSize(200, 85);
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < matrica.GetLength(0); i++)
                {
                    for (int j = 0; j < matrica.GetLength(1); j++)
                    {
                        matrica[i, j] = rnd.Next(0, 2);
                        Console.Write(matrica[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
