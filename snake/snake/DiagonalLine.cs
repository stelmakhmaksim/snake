using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class DiagonalLine
    {
        List<Point> pList;

        public DiagonalLine(int xLeft, int xRight, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            int x = xLeft;
            int y = yTop;
            while (x <= xRight && y <= yBottom)
            {
                Point p = new Point(x, y, '+');
                pList.Add(p);
                x++;
                y++;
            }
        }

        public DiagonalLine(int xLeft, int xRight, int yTop, int yBottom, char sym, char prov)
        {
            pList = new List<Point>();
            int x = xRight;
            int y = yTop;
            while (x >= xLeft && y <= yBottom)
            {
                Point p = new Point(x, y, '+');
                pList.Add(p);
                x--;
                y++;
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
