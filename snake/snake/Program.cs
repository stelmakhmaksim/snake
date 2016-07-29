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
            VerticalLine v1 = new VerticalLine(0,10,5,'%');
            Draw(v1);// вертикальная линия тоже фигура, поэтому можно вызвать метод Draw

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Directions.right);
            //когда сделал такую операцию, рассматриваем fSnake исключительно как фигуру и не могу использовать методы, которые реализованы в классе Snake
            Draw(fSnake);
            Snake snake = (Snake)fSnake;//приведение типа//можно использовать методы, которые есть у змейки, т.к. сделали приведение типа
         
            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();// может хранить линию и змейку, потому что они являются фигурами
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);
            
            foreach(Figure f in figures)
            {
                f.DrawLine();
            }

            Console.ReadLine();
        }

        static void Draw(Figure figure)//принимает любую фигуру и вызывает для неё метод draw
        {
            figure.DrawLine();
        }   
    }
}
//полиморфизм-обозначает многообразие форм и имеет несколько аспектов:
//1 аспект: во время выполнения объекты производного класса могут рассматриваться как объекты базового класса, в таких местах,
//как параметры методов, коллекции или массивы. Когда это происходит, объявленный тип объекта перестаёт соответствовать своему типу во время выполнения.
//2 аспект: у всех наследников класса Figure есть метод DrawLine, могу переопределить метод и задать другую реализацию