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

        public HorizontalLine()
        {
            Point p1 = new Point(4, 5, '+');
            Point p2 = new Point(5, 5, '+');
            Point p3 = new Point(6, 5, '+');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
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
