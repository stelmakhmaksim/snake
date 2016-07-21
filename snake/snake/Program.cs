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
            Point p1 = new Point(1, 3, '*');//новая точка + функция(конструктор), которая заходит в конструктор в классе
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            /*p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/
            p2.Draw();

            Console.ReadLine();
        }
    }
}
//когда есть конструктор и метод, этот принцип называется инкапсуляцией
//инкапсуляция-свойство системы, позволяющее объеденить данные и методы работающие с ними в классе, и скрыть все детали
//реализации от пользователя
