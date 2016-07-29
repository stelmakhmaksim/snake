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

        public virtual void DrawLine()//virtual для того, чтобы наследник мог переопределить этот метод и написать свою реализацию
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
