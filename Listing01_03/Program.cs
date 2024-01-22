//Использование пространства имен:
using System.Windows.Forms;
using Microsoft.VisualBasic;
//Класс с главным методом программы:
class DialogDemo
{
    static void Main()
    {
        string name;
        // отображение окна с полем ввода:
        name = Interaction.InputBox(
            "Как вас зовут?", //Текст над полем ввода
            "Давайте познакомимся..." //Название окна
            );
        //ещё одна текстовая переменная:
        string txt = "Очень приятно, " + name + "!";
        //Окно с сообщением:
        MessageBox.Show(txt, "Знакомство состоялось");
       // MessageBox.Show("Программа кнопки","Первая программа",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk); 
    }
}