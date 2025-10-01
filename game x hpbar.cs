using System;
using System.Drawing;
using System.IO;
using System.Text;



class game
{
    static void Main()
    {
        int hp = 10, maxhp = 10, hp_enemy = 20, maxhp_enemy = 20;
        int damage = 2, damae_enemy = 2;
        int hp_poithion_heal = 5, damage_poithion = 1;
        bool while_1 = true;
        int armor = 10, aromor_enemy = 10;
        string[] skills;
        string[] effect;
        while (while_1)
        {
            HPbar(hp, maxhp, ConsoleColor.Green, 1);
            Console.Write($" hp:{hp}/{maxhp}");

            HPbar(hp_enemy, maxhp_enemy, ConsoleColor.Red, 2);
            Console.Write($" hp:{hp_enemy}/{maxhp_enemy}");

            Console.WriteLine(
                "\nH-Купить зелье здоровья\nD-Купить зелье силы");
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.Spacebar:
                    hp_enemy -= damage;
                    hp -= damae_enemy;
                    break;
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
    }

