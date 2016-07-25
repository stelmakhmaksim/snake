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
            p.Draw();

            Emploee e = new Emploee();
            e.age = 42;
            e.pay = 30000;
            e.weight = 72;
            e.hight = 178;
            e.expirence = 5;

            Console.Write(e.age);

            Console.ReadLine();
        }
    }
}
//наследование-это свойство системы, позволяющее писать новый класс на основе уже существующего,
//частично или полностью замещающейся функциональностью