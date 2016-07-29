using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Directions direction;

        public Snake(Point tail, int lenght, Directions _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public bool pressed_key(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Directions.left;
                return true;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Directions.right;
                return true;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Directions.up;
                return true;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Directions.down;
                return true;
            }
            else if (key == ConsoleKey.Escape)
                return false;
            return true;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            //if(head.x ==food.x && head.y==food.y)
            {
                head.Draw();
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}