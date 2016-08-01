using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;//protected, чтобы переменная pList была видна у наследников

        public void DrawLine()
        {
            foreach (Point p in pList)
                p.Draw();
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))// змейка, пересекаешься ли ты с какой-либо точкой?
                    return true;
            }
            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))//точка змейки пересекаешься ли ты с точкой линии
                    return true;
            }
            return false;
        }
    }
}
