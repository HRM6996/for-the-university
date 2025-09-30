using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
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
            int healt = 9, maxhealt = 10;
            healtbar (healt, maxhealt, ConsoleColor.Magenta);
        }
        static void healtbar(int value, int maxvalue, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++) 
            {
                bar += " ";
            }
            Console.SetCursorPosition(0, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for(int i = value;i < maxvalue; i++)
            {
                bar += " ";
            }
            Console.Write(bar + ']');
            Console.ReadKey();
        }
    }
}

