using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_Конструкторы_и_деструкторы_при_многоуровневом_наследовании
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание анонимное объекта
            new Charlie();
        }
    }
    class Alpha
    {
        //конструктор
        public Alpha()
        {
            Console.WriteLine("Конструктор класса Alpha");
        }
        //деструктор
        ~Alpha()
        {
            Console.WriteLine("Деструктор класса Alpha");
        }
    }
    class Bravo : Alpha
    {
        //конструктор
        public Bravo(): base()
        {
            Console.WriteLine("Конструктор класса Bravo");
        }
        //деструктор
        ~Bravo()
        {
            Console.WriteLine("Деструктор класса Bravo");
        }
    }
    //производный класс от класса Bravo
    class Charlie: Bravo
    {
        //конструктор
        public Charlie():base()
        {
            Console.WriteLine("Конструктор класса Charlie");
        }
        ~Charlie()
        {
            Console.WriteLine("Деструктор класса Charlie");
        }
    }
}
