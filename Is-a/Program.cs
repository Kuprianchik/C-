using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Is_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knigth warrior1 = new Knigth(100, 44);
            Barbarian warrior2 = new Barbarian(100, 1, 22, 2);
            warrior1.TakeDamage(warrior2.DaiDamage());
            warrior2.TakeDamage(warrior1.DaiDamage());
            Console.Write("Рыцарь:\n");
            warrior1.ShowInfo();
            Console.Write("Варвар:\n");
            warrior2.ShowInfo();
            warrior1.Pray();
            warrior2.Shout();
            warrior1.TakeDamage(warrior2.DaiDamage());
            warrior2.TakeDamage(warrior1.DaiDamage());
            Console.Write("Рыцарь:\n");
            warrior1.ShowInfo();
            Console.Write("Варвар:\n");
            warrior2.ShowInfo();

        }
        class Warrior
        {
            protected int Health;
            protected int Armor;
            protected int Damage;
            public Warrior(int health, int armor, int damage)
            {
                Health = health;
                Armor = armor;
                Damage = damage;
            }
            public void TakeDamage(int damage)
            {
                Health -= damage - Armor;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Здоровье: {Health}");
            }
            public int DaiDamage()
            {
                return this.Damage;
            }
        }
        class Knigth : Warrior
        {
            public Knigth(int health, int damage) : base(health, 5, damage) { }
            public void Pray()
            {
                Armor += 2;
            }
        }
        class Barbarian : Warrior
        {
            public Barbarian(int health, int armor, int damage,int attackSpeed) : base(health, armor, damage * attackSpeed) { }          
            
            public void Shout()
            {
                Armor -= 2;
                Health += 10;
            }
        }
    }
}
