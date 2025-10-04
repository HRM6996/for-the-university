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
        int hp_poithion_heal = 5, damage_poithion = 1,mana_poithion = 4;
        int mana = 20, maxmana = 20;
        bool while_1 = true;
        int armor = 10, aromor_enemy = 10;
        int[] skills = { 0, 0, 0, };
        string[] effect = new string[3];
        string[] effect_enemy = new string[3];
        int []move_magic = new int[3];
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
                    Console.WriteLine("\nH-Купить зелье здоровья\nD-Купить зелье силы\nM-Купить зелье маны");
                    shopInfo = Console.ReadKey();
                    switch (shopInfo.Key)
                    {
                        case ConsoleKey.M:
                            mana += mana_poithion;
                            if (mana >= maxmana)
                            {
                                mana = maxmana;
                                break;
                            }
                            else
                            {
                                break;
                            }
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
                            selectmagic(ref mana,5, ref skills[0], ref hp_enemy, 5);
                            clearConsole(9,11);
                            effectBar("faerball", "hero", move_magic);
                            hp -= damae_enemy;
                            break;
                        case ConsoleKey.P:
                            selectmagic(ref mana,5, ref skills[1], ref hp_enemy, 1);
                            clearConsole(9,11);
                            effectBar("poithon", "hero", move_magic);
                            break;
                        case ConsoleKey.T:
                            selectmagic(ref mana,10, ref skills[2], ref hp_enemy, 10);
                            clearConsole(9,11);
                            effectBar("thunderball", "hero", move_magic);
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
    static void effectBar(string magic, string target, int[]move)
    {
        (int left, int top) = Console.GetCursorPosition();
        if (target == "hero")
        {
            switch (magic)
            {
                case "faerball":
                    Console.SetCursorPosition(36,4);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" {move[0]} ");
                    Console.ResetColor();
                    break;
                case "poithon":
                    Console.SetCursorPosition(39,4);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write($" {move[1]} ");
                    Console.ResetColor();
                    break;
                case "thunderball":
                    Console.SetCursorPosition(42,4);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($" {move[2]} ");
                    Console.ResetColor();
                    break;
            }

        }
        else if (target == "enemy")
        {
            switch (magic)
            {
                case "faerball":
                    Console.SetCursorPosition(30,10);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write($" {move} ");
                    Console.ResetColor();
                    break;
                case "poithon":
                    Console.SetCursorPosition(21, 3);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"{move}");
                    Console.ResetColor();
                    break;
                case "thunderball":
                    Console.SetCursorPosition(22, 3);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{move}");
                    Console.ResetColor();
                    break;
            }
            Console.SetCursorPosition(left, top);
            
        }

    }
    static void selectmagic(ref int mana, int manacost, ref int skills, ref int hp_enemy , int damage)
    {
        if (mana >= 5)
        {
            mana -= 5;
            skills = 5;
            hp_enemy -= damage;

        }
        else
        {
            Console.WriteLine("Вам не хватает маны");
        }
        return;
    }
}
