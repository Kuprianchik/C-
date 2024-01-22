using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
         {
                new Player("Джон",100),
                new Player("Билл",220),
                new Player("Дерек",260),
                new Player("Klark",241)
        };
            List<Player> players2= new List<Player>
         {
                new Player("Майкл",300),
                new Player("Джордан",120)
        };
            var filtredPlayers = players.Skip(1);//пропустить 1 элемент
            var filtredPlayers2 = players.Take(1);//получить 1 элемент
            var filtredPlayers3 = players.TakeWhile(player => player.Name.ToUpper().StartsWith("Д"));//получает пока начинает выборка идет до первого отличия TakeWhile, SkipWhile
            var unitedTeam = players.Union(players2).OrderByDescending(player => player.Level);//обьеденение Union
            //List<Player> filtredPlayer = new List<Player>();
            //foreach(var player  in players) 
            //{
            //    if(player.Level > 200)
            //    {
            //        filtredPlayer.Add(player);
            //    }
            //}
            var newPlayers = from Player player in players select new { Name = player.Name, dateOfBirth = DateTime.Now };//создание newPlayers с новыми полями
            var newPlayers2 = players.Select(player => new { Name = player.Name, dateOfBirth = "понедельник" });// с помощью метода Select
            List<int> numbers = new List<int> { 1, 5, 100, 0, 2, 1, 3, 4, 85, 9, 6, 4, 7 };
            int maxNumber = numbers.Min();
            int Max = players.Max(player => player.Level);//linQ макс
            Console.WriteLine(Max);
            var orderevPlayersByLevel = players.Where(player => player.Level > 100).OrderByDescending(player => player.Level);//выборка и сортировка по уровню OrderBy по возрастанию, OrderByDescending по убыв.
            //var filtredplayers = from player player in players where player.level > 200 select player; //запрос linq
            //var filtredplayers2 = players.where(player => player.level > 200).select(player => player.name);//методы расширения linq
            //var filtredplayers3 = players.where(player => player.name.toupper().startswith("k"));//простой запрос с 1 коллекции,начинаются на англ. k
            //foreach (var player in orderevPlayersByLevel)
            //{
            //    Console.WriteLine(player.Name + " " + player.Level);
            //}
            //foreach (var player in newPlayers2)
            //{
            //    Console.WriteLine(player.Name +" " +player.dateOfBirth);
            //}
            foreach(var player in filtredPlayers3)
            {
                Console.WriteLine($"{player.Name} уровень {player.Level}");
            }
        }
    }


    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public Player(string login, int level)
        {
            Name = login;
            Level = level;
        }
    }
}
