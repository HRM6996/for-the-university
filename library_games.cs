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
            string[] your_games = new string[9];
            int your_number = 0;
            string[,] games =
            {
                {"EU4", "CK3", "Stellaris", }, //стратегии
                {"Dota 2","LoL", "Heroes of the Storm"}, //мобы
                {"CsGo2", "Warface", "Deadlock" } //шутеры
            };
            while (true)
            {
                Console.WriteLine("Добро пожаловать в библиотеку игр, выберите раздел\n1-Стратегии\n2-Мобы\n3-Шутеры\n4-Ваши игры");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine($"Выберете игру: \n1-{games[0, 0]}\n2-{games[0, 1]}\n3-{games[0, 2]}");
                        int select_1 = Convert.ToInt32(Console.ReadLine());
                        switch (select_1)
                        {
                            case 1:
                                if (!string.IsNullOrEmpty(games[0, select_1 - 1]))
                                {
                                    your_number++;
                                    Console.WriteLine($"Вы взяли: {games[0, select_1 - 1]}");
                                    your_games[your_number-1] = games[0, select_1 - 1];
                                    games[0, select_1 - 1] = "";
                                    Console.WriteLine("Нажмите любую кнопку");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else Console.WriteLine("Данная игра уже есть у вас");
                                {
                                    Console.WriteLine("Нажмите любую кнопку");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Выберете игру: \n1-{games[1, 0]}\n2-{games[1, 1]}\n3-{games[1, 2]}");
                        int select_2 = Convert.ToInt32(Console.ReadLine());
                        if (!string.IsNullOrEmpty(games[1, select_2 - 1]))
                        {
                            your_number++;
                            Console.WriteLine($"Вы взяли: {games[1, select_2 - 1]}");
                            your_games[your_number - 1] = games[1, select_2 - 1];
                            games[1, select_2 - 1] = "";
                            Console.WriteLine("Нажмите любую кнопку");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else Console.WriteLine("Данная игра уже есть у вас");
                        {
                            Console.WriteLine("Нажмите любую кнопку");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    case 3:
                        Console.WriteLine($"Выберете игру: \n1-{games[2, 0]}\n2-{games[2, 1]}\n3-{games[2, 2]}");
                        int select_3 = Convert.ToInt32(Console.ReadLine());
                        if (!string.IsNullOrEmpty(games[2, select_3 - 1]))
                        {
                            your_number++;
                            Console.WriteLine($"Вы взяли: {games[2, select_3 - 1]}");
                            your_games[your_number - 1] = games[2, select_3 - 1];
                            games[2, select_3 - 1] = "";
                            Console.WriteLine("Нажмите любую кнопку");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else Console.WriteLine("Данная игра уже есть у вас");
                        {
                            Console.WriteLine("Нажмите любую кнопку");
                            Console.ReadKey();
                            Console.Clear(); 
                        }

                        break;
                    case 4:
                        Console.WriteLine($"Твои игры:");
                        for (int i = 0; i < your_games.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(your_games[i]))
                                Console.WriteLine($"{your_games[i]}");
                        }
                        Console.WriteLine("Нажмите любую кнопку");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
