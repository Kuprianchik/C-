using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace самостоятельная_работа_массивы
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //FirstProgramm labaFirst = new FirstProgramm();//первая программа
            //labaFirst.Show();
            //SecondProgram secondlaba = new SecondProgram();//вторая программа
            //secondlaba.Show();
            ThirdProgramm third = new ThirdProgramm(); //третья программа
            third.Show();
        }
    }
    class FirstProgramm
    {
        public void Show()
        {
            //задача 1
            Console.WriteLine("Введите размерность массива");
            try
            {
                int y = Int32.Parse(Console.ReadLine());
                Console.WriteLine("корректный код");
                int[] mas = new int[y];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = (1 + i) * 5 + 2;
                    Console.Write(mas[i] + " ");
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Неккоректный ввод размерности массива");
            }
        }

    }
    class SecondProgram
    {
        public void Show()
        {
            double[] mas = new double[11];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Math.Pow(2, i + 1);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("В обратном порядке");
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
    class ThirdProgramm
    {
        public void Show()
        {
            Console.WriteLine("Введите размерность массива");
            try
            {
                int y = Int32.Parse(Console.ReadLine());
                Console.WriteLine("корректный код");
                char[] mas = new char[y];
                mas[0] = 'a';
                for (int i = 1; i < mas.Length; i++)
                {
                    mas[i] = (char)(mas[i-1]+2);
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i]+" "); ;
                }
                Console.WriteLine();
                Console.WriteLine("В обратном порядке");
                for (int i = y-1; i >= 0; i--)
                {
                    Console.Write(mas[i] + " ");
                }
            }
            catch
            {
                Console.WriteLine("Неккоректный ввод размерности массива");
            }
        }
    }
}
