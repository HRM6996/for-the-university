using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



class mining
{
    static void Main()
    {
        int bar = 0, maxbar = 50;
        int MHash = 100, money = 0;
        double btc = 0, btc_price = 200000;
        Random rand = new Random();
        ConsoleKeyInfo exit;
        bool mining = true;
        int btc_rnd = 0;


        while (true)
        {
            int numb = 3;
            Task.Run(() =>
            {
                while (true)
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.E)
                        {
                            mining = false;
                            Console.Clear();
                            bar = 0;
                            break;
                        }

                        Thread.Sleep(50);
                    }

            });
            Task.Run(() =>
            {
                while (true)
                {
                    btc_rnd = rand.Next(-100, 200);
                    if (btc_rnd > 80 && btc_rnd < 100)
                    {
                        btc_rnd = Convert.ToInt32((btc_rnd / 100) * 1.5);
                    }

                    if (btc_rnd > 150)
                    {
                        btc_rnd = Convert.ToInt32(Math.Sqrt(btc_rnd));
                    }

                    btc_price += btc_rnd;
                    Thread.Sleep(50);
                }
            });
            /*Task.Run(() =>
            {
                while (true)
                {
                    (int left, int top) = Console.GetCursorPosition();
                    Console.SetCursorPosition(50,3);
                    Console.WriteLine($"Курс биткоина:{btc_price}");
                    Console.SetCursorPosition(left,top);
                    Thread.Sleep(300);
                }
                
            });*/

        Console.WriteLine(
                "Добро пожаловать в систему майнинга\n1-Начать майнинг\n2-Открыть магазин асиков\n3-Открыть биржу");
            int user_select = Convert.ToInt32(Console.ReadLine());
            switch (user_select)
            {
                case 1:
                    mining = true;
                    Console.Clear();
                    while (mining)
                {
                    double btc_vrem = 0;
                    Minebar(bar,maxbar,ConsoleColor.DarkYellow,1);
                    Console.SetCursorPosition(0,2);
                    Console.WriteLine("E-Чтобы закончить майнинг");
                    Thread.Sleep(100);
                    bar+= MHash/100;
                    if (bar>=maxbar)
                    {
                        bar = 0;
                        btc_vrem= rand.NextDouble()/800;
                        Console.SetCursorPosition(0, numb);
                        Console.WriteLine($"Вам зачислено{btc_vrem} BTC");
                        btc += btc_vrem;
                        numb++;
                    }
                } break;
                case 2:
                    Console.Clear();
                    Console.Write("1-Купить майнер первого уровня ");
                    Textcolor("(100-монет)", ConsoleColor.Yellow);
                    Textcolor("(100 MHash)", ConsoleColor.DarkMagenta);
                    Console.Write("\n2-Купить майнер второго уровня ");
                    Textcolor("(500-монет)", ConsoleColor.Yellow);
                    Textcolor("(600 MHash)", ConsoleColor.DarkMagenta);
                    Console.Write("\n3-Купить майнер второго уровня ");
                    Textcolor("(1000-монет)", ConsoleColor.Yellow);
                    Textcolor("(1300 MHash)", ConsoleColor.DarkMagenta);
                    Console.WriteLine("\n4-Выйти");
                    int select_shop =  Convert.ToInt32(Console.ReadLine());
                    switch (select_shop)
                    {
                        case 1:
                            if (money >= 100)
                        {
                            money -= 100;
                            MHash += 100;
                            Console.Clear();
                            Console.WriteLine("Вы приобрели майнер");
                        }
                            else if (money < 100)
                            {
                            Console.Clear();
                                Console.WriteLine("Недостаточно денежных средств");
                            }
                            break;
                        case 2:
                            if (money >= 500)
                            {
                                money -= 500;
                                MHash += 600;
                                Console.Clear();
                                Console.WriteLine("Вы приобрели майнер");
                            }
                            else if (money < 500)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно денежных средств");
                            }
                            break;
                        case 3:
                            if (money >= 1000)
                            {
                                money -= 1000;
                                MHash += 1300;
                                Console.Clear();
                                Console.WriteLine("Вы приобрели майнер");
                            }
                            else if (money < 1300)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно денежных средств");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать в обменник\n1-Продать биткоины\n2-выйти");
                    int select_trade = Convert.ToInt32(Console.ReadLine());
                    if (select_trade == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"Курс Биткоина сейчас составлет: {btc_price}");
                        Console.WriteLine($"Введите сколько вы хотите обменять биткоинов, у вас сейчас:{btc} ");
                        double btc_input = Convert.ToDouble(Console.ReadLine());
                        if (btc_input <= btc)
                        {
                            int money_vrem = 0;
                            money_vrem +=Convert.ToInt32( btc_input * btc_price);
                            Console.Clear();
                            money += money_vrem;
                            Console.WriteLine($"Вам зачисленно {money_vrem} денег ");
                            btc -= btc_input;
                        }
                    }
                    else if (select_trade == 2)
                    {
                        Console.Clear();
                        break;
                        
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                    break;
            }
            
        }

        static void Minebar(int bar, int maxbar, ConsoleColor color_user, int cursorpos)
        {
            
            Console.SetCursorPosition(0, cursorpos);
            Console.Write('[');
            Console.BackgroundColor = color_user;
            for (int i = 0; i < bar; i++)
            {
                Console.Write(" ");
            }
            Console.ResetColor();
            for (int i = bar; i < maxbar; i++)
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
    }
}
