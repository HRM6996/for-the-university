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
            Console.WriteLine("добро пожаловать в игру");
            Console.CursorVisible = true;
            
            int money = 1000;
            int build = 50;
            int upgrade = 100;
            int y_large = 3;
            int x_large = 3;
            int user_input_upgrade_x =0;
            int user_input_upgrade_y =0;
            int user_input_build_x = 0;
            int user_input_build_y = 0;
            int betta_x_build = 0;
            int betta_y_build = 0;
            int betta_x_upgrade = 0;
            int betta_y_upgrade = 0;
            Console.SetCursorPosition(20,22);
            Console.WriteLine($"Ваш балланс: {money}");
            char[,] map =
            {
                {' ',' ',' '},
                {' ',' ',' '}, 
                {' ',' ',' '},
            };
            while (true)
            {
                int all_build = 0;
                int tik_money = 0;
                {
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            Console.Write(map[i, j]);
                        }

                        Console.WriteLine();
                    }
                }
                Console.WriteLine("1-Купить дом\n2-Купить улучшение для дома\n3-Следующий ход");
                int user_input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (user_input == 3)
                {
                    Console.WriteLine("Нажмите пробел для следующего хода");
                }

                if (user_input == 2)
                {
                    if (money >= upgrade)
                    {
                        Console.WriteLine("Выберите клетку для улучшения");
                        Console.WriteLine("Введите номер строки:");
                        betta_x_upgrade = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Введите номер столбца:");
                        betta_y_upgrade = Convert.ToInt32(Console.ReadLine());
                        user_input_upgrade_x = betta_x_build-1;
                        user_input_upgrade_y = betta_y_build-1;
                        Console.Clear();
                         if (betta_x_upgrade >  x_large || betta_y_upgrade > y_large)
                        {
                            Console.WriteLine("Вы ввели не верную позицию, попробуйте в приделах 3x3");
                            Console.ReadKey();
                        }
                        else if (map[user_input_upgrade_x , user_input_upgrade_y ] == '#' && betta_x_upgrade <=  x_large && betta_y_upgrade <= y_large)
                        {
                            map[user_input_upgrade_x , user_input_upgrade_y ] = '*';
                        money -= upgrade;
                        }
                        
                    }
                    else if (money < upgrade)
                    {
                        Console.WriteLine($"Вам не хватает {upgrade-money} денег");
                    }

                }
                if (user_input == 1 && money >= build )
                {
                    Console.WriteLine("Впишите номер строки, где вы хотите построить дом ");
                    betta_x_build = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Впишите номер столбца, где вы хотите построить дом ");
                    betta_y_build= Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    user_input_build_x = betta_x_build-1;
                    user_input_build_y = betta_y_build-1;
                    if (betta_x_build >  x_large || betta_y_build > y_large)
                    {
                        Console.WriteLine("Вы ввели не верную позицию, попробуйте в приделах 3x3");
                        Console.ReadKey();
                    }
                    else if (map[user_input_build_x , user_input_build_y ] != '#' && betta_x_build <=  x_large && betta_y_build <= y_large)
                    {
                        map[user_input_build_x , user_input_build_y ] = '#';
                        money -= build;
                    }
                    else 
                    {
                        Console.WriteLine("На данном месте уже построен дом");
                    }

                }
                else 
                {
                    Console.WriteLine("У вас не хватает денег");
                }

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i,j] == '#') 
                            all_build++;
                        if (map[i,j] == '*')
                            all_build+=2;
                    }
                    Console.WriteLine();
                    
                }

                switch (user_input)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.Clear();
                        break;
                }
                Console.SetCursorPosition(20,20);
                Console.WriteLine($"У вас {all_build} дом(ов) ");
                tik_money = all_build * 10;
                Console.SetCursorPosition(20,21);
                Console.WriteLine($"Ваш доход составляет {tik_money} в ход");
                money+= tik_money;
                Console.SetCursorPosition(20,22);
                Console.WriteLine($"Ваш балланс: {money}");
            }
        }
    }
}
        
                
