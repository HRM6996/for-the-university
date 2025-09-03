using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float deposit;
            int years;
            int procent;
            string zat = "--------------------------------------------------------------------------------------------------------------------------";
            float balance;

            Console.WriteLine("Введите ваш депозит в банке ");
            balance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите процент вклада ");
            procent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите на сколько лет хотите оставить деньги в банке ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zat);

            deposit = balance;

            for (int i = 0; i < years;i++)
            {
                deposit += deposit / 100 * procent;
                Console.WriteLine($"статистика за  {i+1} год по вкладу в банке ");
                Console.WriteLine($"В этом году вы получили {deposit / 100 * procent} со вклада");
                Console.WriteLine($"Ваш балланс в банке составляет {deposit} ");
                Console.WriteLine(zat);
                Console.ReadKey();
            }
            Console.WriteLine($"В общей сложности, ваш балланс изменился на {deposit - balance} а в процентном соотношении, это" +
                $"{deposit / (balance / 100)-100}%");
        }
    }
}
