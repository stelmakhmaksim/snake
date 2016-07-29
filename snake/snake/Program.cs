﻿using System;
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
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Directions.right);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);
            
            foreach(var f in figures)
            {
                f.DrawLine();
            }
        }

        static void Draw(Figure figure)
        {
            figure.DrawLine();
        }

        Console Read();
    }
}