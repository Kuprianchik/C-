using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace бой_героев_с_помощью_классов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int figtherNumber;
            Figter[] fighters =
            {
                new Figter("Джон",500,50,0),
                new Figter("Майкл",250,25,20),
                new Figter("Алекс",150,100,10),
                new Figter("Джек",300,75,5)
            };
            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write($"Боец № {i + 1} ");
                fighters[i].ShowStats();
            }
            Console.WriteLine("\n** " + new string('-', 25) + "**");
            Console.Write("\nВыберите номер первого бойца: ");
            figtherNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Figter firstFigter = fighters[figtherNumber];
            Console.Write("\nВыберите номер второго бойца: ");
            figtherNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Figter secondFighter = fighters[figtherNumber];
            Console.WriteLine("\n** " + new string('-', 25) + "**");

            while (firstFigter.Health > 0 && secondFighter.Health > 0)
            {
                firstFigter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFigter.Damage);
                firstFigter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
            }
        }

    }
    class Figter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;
        public int Health { get { return _health; } }
        public int Damage { get { return _damage; } }
        public Figter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Боец - {_name}, здоровье: {_health}, наносимый урон: {_damage}, броня: {_armor}.");
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}.");
        }
        public void TakeDamage(int damage)
        {
            _health -= damage;
        }
    }
}
