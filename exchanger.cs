using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        float rubusd = 80.805f;
        float usdrub = 0.0124f;
        float rubeur = 93.5f;
        float eurrub = 0.0106f;
        string otvet;
        float summa;
        float balanceRub;
        float balanceEur = 0;
        float balanceUsd = 0;
        float balanceRub_vrem = 0;
        float balanceEur_vrem = 0;
        float balanceUsd_vrem = 0;
        string zatichka = "------------------------------------------------------------------------------------------";
        float comissia = 0.05f;

        Console.WriteLine($"Это обменик валют, комиссия за сделку составляет {comissia * 100}%");

        Console.WriteLine("Сколько у вас рублей");
        balanceRub = Convert.ToSingle(Console.ReadLine());


        while (true)
        {

            Console.WriteLine(zatichka);
            Console.WriteLine("Введите то, что вы хотите конвертировать?");
            Console.WriteLine("Rub/Usd");
            Console.WriteLine("Usd/Rub");
            Console.WriteLine("Rub/Eur");
            Console.WriteLine("Eur/Rub");
            otvet = Console.ReadLine();
            Console.WriteLine(zatichka);

            switch (otvet)
            {
                case "Rub/Usd":
                    Console.WriteLine("Введите сколько рублей вы хотите обменять");
                    break;
                case "Usd/Rub":
                    Console.WriteLine("Введите сколько долларов вы хотите обменять");
                    break;
                case "Rub/Eur":
                    Console.WriteLine("сколько рублей вы хотите обменять");
                    break;
                case "Eur/Rub":
                    Console.WriteLine("сколько евро вы хотите обменять");
                    break;
                default:
                    Console.WriteLine("Ошибка, введите курс из списка");
                    break;
            }
            summa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(zatichka);
            if (summa > 0)
            {
                switch (otvet)
                {
                    case "Rub/Usd":
                        if (balanceRub >= summa)
                        {
                            balanceUsd_vrem += summa / rubusd;
                            balanceRub -= summa;
                            balanceUsd += balanceUsd_vrem - balanceUsd_vrem * comissia;
                            Console.WriteLine($"на ваш балланс зачисленно {balanceUsd_vrem} Долларов");
                            Console.WriteLine(zatichka);
                        }
                        else
                        {
                            Console.WriteLine("вы ввели сумму превышающую ваш балланс");
                        }
                        break;

                    case "Usd/Rub":
                        if (balanceUsd >= summa)
                        {
                            balanceRub_vrem += summa / usdrub;
                            balanceUsd -= summa;
                            balanceRub += balanceRub_vrem - balanceRub_vrem * comissia;
                            Console.WriteLine($"на ваш балланс зачисленно {balanceRub_vrem} Рублей");
                            Console.WriteLine(zatichka);
                        }
                        else
                        {
                            Console.WriteLine("вы ввели сумму превышающую ваш балланс");
                        }
                        break;
                    case "Rub/Eur":
                        if (balanceRub >= summa)
                        {
                            balanceEur_vrem += summa / rubeur;
                            balanceRub -= summa;
                            balanceEur += balanceEur_vrem - balanceEur_vrem * comissia;
                            Console.WriteLine($"на ваш балланс зачисленно {balanceEur_vrem} Евро");
                            Console.WriteLine(zatichka);
                        }
                        else
                        {
                            Console.WriteLine("вы ввели сумму превышающую ваш балланс");
                        }
                        break;
                    case "Eur/Rub":
                        if (balanceEur >= summa)
                        {
                            balanceRub_vrem += summa / eurrub;
                            balanceEur -= summa;
                            balanceRub += balanceRub_vrem - balanceRub_vrem * comissia;
                            Console.WriteLine($"на ваш балланс зачисленно {balanceRub_vrem} Рублей");
                            Console.WriteLine(zatichka);
                        }
                        break;
                }

            }
            else
            {
                switch (otvet)
                {
                    case "Rub/Usd":
                        balanceUsd_vrem += balanceRub / rubusd;
                        balanceRub = 0f;
                        balanceUsd += balanceUsd_vrem - balanceUsd_vrem * comissia;
                        Console.WriteLine($"на ваш балланс зачисленно {balanceUsd_vrem} Долларов");
                        Console.WriteLine(zatichka);

                        break;
                    case "Usd/Rub":
                        balanceRub_vrem += balanceUsd / usdrub;
                        balanceUsd = 0f;
                        balanceRub += balanceRub_vrem - balanceRub_vrem * comissia;
                        Console.WriteLine($"на ваш балланс зачисленно {balanceRub_vrem} Рублей");
                        Console.WriteLine(zatichka);
                        break;
                    case "Rub/Eur":
                        balanceEur_vrem += balanceRub / rubeur;
                        balanceRub = 0f;
                        balanceEur += balanceEur_vrem - balanceEur_vrem * comissia;
                        Console.WriteLine($"на ваш балланс зачисленно {balanceEur_vrem} Евро");
                        Console.WriteLine(zatichka);
                        break;
                    case "Eur/Rub":
                        balanceRub_vrem = balanceEur / eurrub;
                        balanceEur = 0f;
                        balanceRub += balanceRub_vrem - balanceRub_vrem *    comissia;
                        Console.WriteLine($"на ваш балланс зачисленно {balanceRub_vrem} Рублей");
                        Console.WriteLine(zatichka);
                        break;
                }
            }
                Console.WriteLine(zatichka);
                Console.WriteLine("Ваши активы");
                Console.WriteLine($"{balanceRub} Рублей");
                Console.WriteLine($"{balanceUsd} Долларов");
                Console.WriteLine($"{balanceEur} Евро");
            }
        }
    }
