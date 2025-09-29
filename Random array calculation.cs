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
                Random rnd = new Random();
                int user_value = 0;
                while (true)
                {
                bool _while = true;
                    int[,] array = new int[5, 5];
                    Console.WriteLine("Впишите любую цифру");
                    user_value = Convert.ToInt32(Console.ReadLine());
                    int score = 0;
                    if (user_value < 10)
                    {
                        while (_while)
                        {
                            int x = rnd.Next(5);
                            int y = rnd.Next(5);
                            int all = 0;
                            editarray(ref array, x, y, user_value);
                            score++;
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(0); j++)
                                {
                                    Console.Write(array[i, j]);

                                    if (all < 25 && array[i, j] == user_value)
                                    {
                                        all++;
                                    }
                                    if (all >= 25)
                                    {
                                        all = 0;
                                        _while = false;
                                    }

                                }
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine($"Перебор закончен\nПотребовалось {score} раз ");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не допустимое значение");
                    }

                }
            }
            static void editarray(ref int[,] array, int index_x, int index_y, int value)
            {
                array[index_x, index_y] = value;

            }
        }
    }

