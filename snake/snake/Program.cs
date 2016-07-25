using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine h1line = new HorizontalLine(0, 79, 0, '+');
            h1line.DrawLine();
            HorizontalLine h2line = new HorizontalLine(0, 79, 24, '+');
            h2line.DrawLine();

            VerticalLine v1line = new VerticalLine(0, 24, 0, '+');
            v1line.DrawLine();
            VerticalLine v2line = new VerticalLine(0, 24, 79, '+');
            v2line.DrawLine();

            DiagonalLine d1line = new DiagonalLine(0, 79, 0, 24, '+');
            d1line.DrawLine();
            DiagonalLine d2line = new DiagonalLine(54, 79, 0, 24, '+','2');
            d2line.DrawLine();

            Console.ReadLine();
        }
    }
}