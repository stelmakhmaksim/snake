using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);//установим фиксированный размер окна для избежания перемотки

            //отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, 79, 2, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 79, 24, '+');
            VerticalLine leftLine = new VerticalLine(1, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, 23, 79, '+');
            topLine.DrawLine();
            bottomLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            //отрисовка точек
            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 4, Directions.right);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.pressed_key(key.Key);
                }
               Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}