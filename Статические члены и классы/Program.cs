using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статические_члены_и_классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.Identifications = 5;// присвоение
            User user1 = new User();
            User user2 = new User();
            user1.ShowInfo();
            user2.ShowInfo();
        }
    }
    class User
    {
        public static int Identifications;//статичный член
        public int Identification;
        public static int MenHourPrice;
        public User() 
        {
            Identification = ++Identifications;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Identification);
        }
        public static int GetSalaryPerDay(int workedHours)
        {
            return MenHourPrice * workedHours ;
        }
        public int GetSalaryPerMounth(int workedDays)
        {
            return GetSalaryPerDay(8) * workedDays;
        }
    }
}
