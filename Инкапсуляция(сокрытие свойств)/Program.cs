﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инкапсуляция_сокрытие_свойств_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(55, 10);
            renderer.Draw(player.X,player.Y);
        }
      class Renderer
        {
public void Draw(int x,int y, char character='@')
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(x,y);
                Console.Write(character);
                Console.ReadKey(true);
            }
        }
        class Player
        {

            //public int X
            //{
            //    get { return _x; }
            //   //private set { _x = value; }
            //}
            public int X { get; private set; }//автореализуемые свойства
            public int Y { get; private set; }

            public Player(int x, int y) 
            {
                X = x;  
                Y= y;
            }
            //public int GetPositionX()
            //{
            //    return _x;
            //}
            //public int GetPositionY()
            //{
            //    return _y;
            //}

        }
    }
}
