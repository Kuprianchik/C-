using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Виртуальные_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonPlayerCharacter[] characters = new NonPlayerCharacter[] 
            {new NonPlayerCharacter(),
            new Farmer(),
            new Knigth(),
            new Child()};
            foreach(var character in characters)
            {
                character.ShowDescription();
                Console.WriteLine(new string('-',35));
            }
        }
    }
    class NonPlayerCharacter
    {
        public virtual void ShowDescription()// виртуальный метод
        {
            Console.WriteLine("Я простой NPC, умею только гулять.");
        }
    }
    class Farmer : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();//использование основной реализации метода от отцовского
            Console.WriteLine("А ещё я фермер, и умею работать на поле.");// дополнили ее своей
        }
    }
    class Knigth : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, моё дело только сражения!");//переделали, свой вывод
        }

    }
    class Child : NonPlayerCharacter
    {

    }
}
