using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plus;
            string minus;
            string umnozhit;
            string delit;
            float otvet = 0;
            float one;
            float two;
            char mnozh;

            Console.WriteLine("Введит 1 число ");
            one = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введит * / - + ");
            mnozh = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Введит 2 число ");
            two = Convert.ToSingle(Console.ReadLine());

            switch (mnozh)
            {
                case '+':
                    otvet = one + two;
                    break;
                case '-':
                    otvet = one - two;
                    break; 
                case '*':
                    otvet = one * two;
                    break;
                case '/':
                    otvet = one / two;
                    break;
            }
            Console.WriteLine(otvet);

        }
    }
}
