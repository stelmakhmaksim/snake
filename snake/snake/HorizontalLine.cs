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
                Point p = new Point(x, y, '+');
                pList.Add(p);
            }
        }

        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach(Point p in pList)
            {
                p.Draw();
            }

            //base.DrawLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
