using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Одномерные_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 2, 3, 4, 7, 8 };
            bool IsOpen = true;

            while (IsOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 - забронировать места\n\n2 - выход из программы.\n\n");
                Console.Write("Введите номер программы:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (userSector < 0)
                        {
                            Console.WriteLine("Неверное количество мест");
                            break;
                        }
                        if (sectors.Length < userSector)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секторе {userSector} не достаточно мест. Остаток " +
                                $"{sectors[userSector]}");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование прошло успешно!");

                        break;
                    case 2:
                        IsOpen = false;
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
