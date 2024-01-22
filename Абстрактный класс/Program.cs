using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактный_класс
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
            new Car(),
            new Train()};
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

    }
    abstract class Vehicle
    {
        protected float speed;
        public abstract void Move();
        public float GetCurrentSpeed()
        {
            return speed;
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет по асфальту");
        }
    }
    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Поезд едет по рельсам");
        }
    }
}

