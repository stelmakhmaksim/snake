﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;//данные класса
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)//конструктор класса
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directions direction)//оffset - смещение
        {
            if (direction == Directions.right)
            {
                x = x + offset;
            }

            else if (direction == Directions.left)
            {
                x = x - offset;
            }

            if (direction == Directions.up)
            {
                y = y - offset;
            }

            else if (direction == Directions.down)
            {
                y = y + offset;
            }
        }

        public void Draw()//метод класса или функция
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()//override - переопределение, чтобы в отладчике было легче смотреть на значение переменной point
        {
            return x + ", " + y + ", " + sym;
        }


    }
}

/*Алексей, а разве при Direction == Direction.UP не должно быть y = y - offset?
В консоли значение y вверху равно 0, и когда увеличивается идёт вниз на след.строку. 
У вас получается, что когда мы в направление UP сделаем змейку, она будет наоборот вниз идти. То же самое с DOWN.*/