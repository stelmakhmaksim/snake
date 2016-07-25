using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');//новая точка + функция(конструктор), которая заходит в конструктор в классе
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');//экземпляры класса - объекты класса поинт
            //p2.Draw();

            HorizontalLine line = new HorizontalLine(0,5,8,'+');
            line.DrawLine();


            Console.ReadLine();
        }
    }
}