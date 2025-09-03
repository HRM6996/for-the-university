using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int stat_win_hero = 0;
            int stat_win_enemy = 0;



            Console.WriteLine("Сколько раз просимулировать бой ?");
            int number_simulathion = Convert.ToInt32(Console.ReadLine());
            int ns = number_simulathion;

            //дальше реализована броня, по формуле которая используется в доте 

            while (number_simulathion > 0)
            {
                int hpenemy = rnd.Next(10, 100);
                int hphero = rnd.Next(10, 100);
                int damageenemy = rnd.Next(20, 50);
                int damagehero = rnd.Next(20, 50);
                int armorhero = rnd.Next(-50, 100);
                int armorenemy = rnd.Next(-50, 100);

                double dota_armor_hero = (0.06 * armorhero) / (1 + 0.06 * Math.Abs(armorhero)); // запуск программы 1000 раз до добавления Math.Abs дал показатель 530на470 и 15 сек времени
                double dota_armor_enemy = (0.06 * armorenemy) / (1 + 0.06 * Math.Abs(armorenemy));// запуск программы 1000 раз после добавления Math.Abs дал показатель 557на443 и <1 сек времени
                while (hphero > 0 && hpenemy > 0)
                {
                    (hpenemy) -= Convert.ToInt32(damagehero * (1 - dota_armor_enemy));
                    if (hpenemy <= 0)
                    {
                        stat_win_hero++;
                        break;
                    }
                    (hphero) -= Convert.ToInt32(damageenemy * (1 - dota_armor_hero));
                    if (hpenemy <= 0 && hphero > 0) stat_win_hero++;
                    if (hpenemy > 0 && hphero <= 0) stat_win_enemy++;

                }
                number_simulathion--;


            }
            Console.WriteLine($"Всего было произведенно {ns} боёв");
            Console.WriteLine($"Число побед героя {stat_win_hero}");
            Console.WriteLine($"Число побед врага {stat_win_enemy}");

        }



    }
}
