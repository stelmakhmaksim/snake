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
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            Point p3 = new Point(7, 8, '*');
            Point p4 = new Point(10, 11, '#');

            List<char> numList = new List<char>();
            numList.Add('*');
            numList.Add('#');

            char x = numList[0];
            char y = numList[1];

            foreach(char i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    }
}
//  у массива фиксированное кол-во элементов и задается при объявлении его, у класса списка нет.
// int[] array2 = { 1, 3, 5, 7, 9 };