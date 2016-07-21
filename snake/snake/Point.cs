using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;//объект класса
        public int y;
        public char sym;

        public void Draw()//метод класса
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
