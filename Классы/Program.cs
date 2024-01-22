using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car ferrari = new car();
            ferrari.Name = "F40";
            ferrari.HorsePower = 471;
            ferrari.Age= 30;
            ferrari.MaxSpeed= 317.0f;

            ferrari.ShowTechicalPasport();
            ferrari.BecomeOlder(5, 50);
            ferrari.ShowTechicalPasport();
            //Console.WriteLine(ferrari.HorsePower);
        }
        class car
        {
            public string Name;
            public int HorsePower;
            public int Age;
            public float MaxSpeed;
            public int Years = 4;

            public void ShowTechicalPasport() //метод в наших классах, в классе Main это функции
            {
                Console.WriteLine($"Название авто {Name}\nКоличество лошадиных сил: {HorsePower}\n" +
                    $"Возраст: {Age}\nМаксимальная скорость: {MaxSpeed} км/ч.");
            }
            public void BecomeOlder(int Years, int runAwayHorses)
            {
                Age += this.Years+Years;
                HorsePower -= runAwayHorses;
            }
        }
    }
}
