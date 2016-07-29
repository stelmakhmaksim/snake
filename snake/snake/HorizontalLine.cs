using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)//горизонтальная линия является представителем фигуры
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void DrawLine()// override для переопределения метода
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.DrawLine();//реализация базового класса фигуры, метода DrawLine
            /*foreach(Point p in pList)
            {
                p.Draw();
            }*/

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
