using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Walls
    {
        public List<Figure> wallist;//использую принцип полиморфизма, т.к. линии наследники класса фигуры
        public Walls(int mapWidth, int mapHeight)
        {
            wallist = new List<Figure>();

            //отрисовка рамочки
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, mapHeight - 1, mapWidth - 2, '+');

            wallist.Add(topLine);
            wallist.Add(bottomLine);
            wallist.Add(leftLine);
            wallist.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(figure))//линия, пересекаешься ли ты со змейкой
                    return true;
            }
            return false;
        }
        internal bool IsHit(Point p)
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(p))//линия, пересекаешься ли ты со змейкой
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallist)
                wall.DrawLine();
        }
    }
}