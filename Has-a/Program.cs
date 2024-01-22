using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Олег");
            Performer worker2 = new Performer("Юрий");
            Task[] tasks = { new Task(worker1, "Выкопать яму."), new Task(worker2, "Вывезти грунт.") };
            Board schedule = new Board(tasks);
            schedule.ShowAllTasks();

        }
        class Performer // работники
        {
            public string Name;
            public Performer(string name) //конструктор класса
            {
                Name = name;
            }
        }
        class Board //класс доска доска имеет задачи, а задачи имеют работников
        {
            public Task[] Tasks; //
            public Board(Task[] tasks) //конструктор класса, имеет задачи
            {
                Tasks = tasks;
            }
            public void ShowAllTasks()//выведение информации 
            {
                for(int i=0; i<Tasks.Length; i++)
                {
                    Tasks[i].ShowInfo();
                }
            }
        }
        class Task //класс задачи
        {
            public Performer Worker; // ссылка на работника
            public string Description; // задача
            public Task(Performer worker, string description) //конструктор класса работник класса Performer и задача стринг
            {
                Worker = worker;
                Description = description;
            }
            public void ShowInfo()//выведение информации
            {
                Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\n");
            }
        }
    }
}
