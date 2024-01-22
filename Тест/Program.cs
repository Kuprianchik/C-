using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гладиаторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float health1 = rand.Next(90, 110);
            int damage1 = rand.Next(7, 35);
            int armor1 = rand.Next(45, 100);

            float health2 = rand.Next(80, 120);
            int damage2 = rand.Next(5, 40);
            int armor2 = rand.Next(65, 100);


            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} брони.");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} брони.");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
                Console.WriteLine(" ");
                
                Console.WriteLine("Здоровье гладиатора 1: " + health1);
                Console.WriteLine("Здоровье гладиатора 2: " + health2);
                Console.WriteLine(" ");
            }
            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья. Оба гладиатора погибли.");
            }
            if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 пал.");
            }
            if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 пал.");
            }

        }
    }
}
