using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List();
            //Queue();
            //Stack();
            Dictionary();

        }
        static void List() // Коллекция лист
        {
            List<int> numbers = new List<int>(5);
            numbers.Add(12);
            //numbers.Clear();//удаление всего листа
            numbers.Add(12);
            numbers.Add(5);
            numbers.Add(9);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(22);
            numbers.Insert(2, 55);
            numbers.AddRange(new int[] { 3, 4, 5 });// добавление в конец целого массива
            //numbers.RemoveAt(3); //удаление по индексу
            //numbers.Remove(12);//удаление 1 по совпадению
            Console.WriteLine($"Число 22 находится на позиции:{numbers.IndexOf(22)} ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        static void Queue() //КОЛЛЕКЦИЯ FIFO первый вошел первый вышел
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Василий");
            patients.Enqueue("Алексей");
            patients.Enqueue("Роман");
            patients.Enqueue("Владимир");
            Console.WriteLine($"Сейчас на прием идет: {patients.Dequeue()}");//выдает значение и удаляет из колекции
            Console.WriteLine($"Следующий в очереди идет: {patients.Peek()}");//дает предоставление первого в колекции
            foreach (var patien in patients)
            {
                Console.WriteLine(patien);
            }
        }
        static void Stack() // коллекция LIFO ПЕРВЫЙ ВОШЕЛ ПОСЛЕДНИЙ УШЁЛ
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine($"Следующее число в стеке: {numbers.Pop()}");// выдает значение и удаляет из колекции
            }

        }
        static void Dictionary()
        {
            Dictionary<string, string> countrieCapitals = new Dictionary<string, string>();
            countrieCapitals.Add("Австралия", "Канберра");
            countrieCapitals.Add("Беларусь", "Минск");
            countrieCapitals.Add("Россия", "Москва");
            countrieCapitals.Add("США", "Вашингтон");
            
            if (countrieCapitals.ContainsKey("Австралия"))
            {
                Console.WriteLine(countrieCapitals["Австралия"]);//Вывод по ключу
            }
            countrieCapitals.Remove("Россия");//удаление по ключу
            foreach (var item in countrieCapitals)
            {
                Console.WriteLine($"Страна - {item.Key}, столица - {item.Value}");
            }
        }
    }
}
