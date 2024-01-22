using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace проверка_числа_на_четность_нечетность
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int number, reminder;
           // number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));
           // //вычисляется остаток от деления на 2:
           //var otvet = (number >= 10);
           // var otvet2 = (number%4);

           // string txt = "Вы ввели ";
           //txt += (otvet == true && otvet2 == 0) ? "да" : "нет";
           // MessageBox.Show(txt);
            //txt += ( == false ? "не удовлетроряет" : "удовлетворяет");
            // КоличествоСотен raschet = new КоличествоСотен();
            //raschet.Show();
            СколькоТысяч raschet = new СколькоТысяч();
            raschet.Show();
        }

    }
    class КоличествоСотен
    {
        protected int number, hundreds;
        protected string txt;

        public virtual void Show()
        {
            number = Int32.Parse(Interaction.InputBox("Введите целое число", "количество сотен"));
            hundreds = number / 100 % 10;
            txt = $"В этом числе {hundreds} сотен!";
            MessageBox.Show(txt);
        }
    }
    class СколькоТысяч:КоличествоСотен
    {
        
        public override void Show()
        {
            number = Int32.Parse(Interaction.InputBox("Введите целое число", "количество тысяч"));
            hundreds = number / 1000 % 10;
            txt = $"В этом числе {hundreds} тысяч!";
            MessageBox.Show(txt);
        }
    }
}
