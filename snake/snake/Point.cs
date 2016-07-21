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

        public Point()//конструктор
        {
            Console.WriteLine("Создается новая точка");
        }

        public Point(int _x, int _y, char _sym)//конструктор класса
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()//метод класса или функция
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}