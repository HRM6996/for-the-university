using System;
using System.Drawing;
using System.IO;
using System.Text;



class game
{
    static void Main()
    {
        ConsoleKeyInfo keyInfo;
        ConsoleKeyInfo magicInfo;
        ConsoleKeyInfo shopInfo;
        Console.CursorVisible = false;
        int hp = 20, maxhp = 20, hp_enemy = 20, maxhp_enemy = 20;
        int damage = 2, damae_enemy = 2;
        int hp_poithion_heal = 5, damage_poithion = 1;
        int mana = 20, maxmana = 20;
        bool while_1 = true;
        int armor = 10, aromor_enemy = 10;
        string[] skills = { "faerball", "poithon", "thunderball" };
        string[] effect = new string[3];
        string[] effect_enemy = new string[3];
        while (while_1)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Вы:");
            HPbar(hp, maxhp, ConsoleColor.Green, 1);
            Console.Write($" хп:{hp}/{maxhp}");

            HPbar(mana, maxmana, ConsoleColor.Blue, 2);
            Console.Write($" мана:{mana}/{maxmana}");

            Console.WriteLine("\nВраг:");
            HPbar(hp_enemy, maxhp_enemy, ConsoleColor.Red, 4);
            Console.Write($" хп:{hp_enemy}/{maxhp_enemy}");
            Console.WriteLine("\nM-Заклинания\nS-Магазин\nПробел-ход");
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.S:
                    clearConsole(10, 12);
                    Console.WriteLine("\nH-Купить зелье здоровья\nD-Купить зелье силы");
                    shopInfo = Console.ReadKey();
                    switch (shopInfo.Key)
                    {
                        case ConsoleKey.H:
                            hp += hp_poithion_heal;
                            if (hp >= maxhp)
                            {
                                hp = maxhp;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        case ConsoleKey.D:
                            damage += damage_poithion;
                            break;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    hp_enemy -= damage;
                    hp -= damae_enemy;
                    break;
                case ConsoleKey.M:
                    clearConsole(10, 12);
                    Console.Write("\nF-Фаерболл");
                    Textcolor("(5маны)", ConsoleColor.Blue);
                    Console.Write("\nP-Отравление");
                    Textcolor("(5маны)", ConsoleColor.Blue);
                    Console.Write("\nT-Молния");
                    Textcolor("(10маны)", ConsoleColor.Blue);
                    magicInfo = Console.ReadKey();
                    switch (magicInfo.Key)
                    {
                        case ConsoleKey.F:
                            if (mana >= 5)
                            {
                                mana -= 5;

                            }
                            break;
                        case ConsoleKey.P:
                            break;
                        case ConsoleKey.T:
                            break;
                    }

                    break;
            }

            if (hp_enemy <= 0)
            {
                while_1 = false;
                Console.Clear();
                Console.WriteLine("ВЫ ПОБЕДИЛИ");
            }
            else if (hp <= 0)
            {
                while_1 = false;
                Console.Clear();
                Console.WriteLine("Вы проиграли");
            }
        }
    }

    static void HPbar(int hp, int maxhp, ConsoleColor color_user, int cursorpos)
    {

        Console.SetCursorPosition(0, cursorpos);
        Console.Write('[');
        Console.BackgroundColor = color_user;
        for (int i = 0; i < hp; i++)
        {
            Console.Write(" ");
        }
        Console.ResetColor();
        for (int i = hp; i < maxhp; i++)
        {
            Console.Write(" ");
        }

        Console.Write(']');
    }
    static string Textcolor(string text, ConsoleColor input_color)
    {
        ConsoleColor base_color = Console.ForegroundColor;
        Console.ForegroundColor = input_color;
        Console.Write($"{text}");
        Console.ForegroundColor = base_color;
        return text;
    }
    static void clearConsole(int start_cler, int end_clear)
    {
        (int left, int top) = Console.GetCursorPosition();
        for (int i = start_cler - 1; i <= end_clear; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }
        Console.SetCursorPosition(left, top);
    }
    static void effectBar(string magic, int second, string target)
    {
        if (target == "hero")
        {
            Console.SetCursorPosition(0, 20);
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else if (target == "enemy")
        {

        }

        }
    }

