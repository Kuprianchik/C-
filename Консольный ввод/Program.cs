using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Консольный_ввод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //Console.Title = "Давайте познакомимся...";
            //Console.Write("Как вас зовут? ");
            //name= Console.ReadLine();
            //string txt = "Очень приятно, " + name + "!";
            //Console.WriteLine(txt);
            string res, txt;
            int year = 2023, age, born;
            res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
            born = Int32.Parse(res);
            age = year - born;
            txt = "Тогда вам " + age + " лет.";
            MessageBox.Show(txt);
        }
    }
}
