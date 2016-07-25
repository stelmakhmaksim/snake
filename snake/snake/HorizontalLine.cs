using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)//конструктор используется для инициализации свойств объекта,
                                                                     //поэтому выводить результат в нём не надо
        {
            pList=new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, '+');
                pList.Add(p);
            }

            foreach (Point p in pList)
            {
                p.Draw();
            }
            
        }

        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
