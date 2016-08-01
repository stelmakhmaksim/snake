using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;//this. задействуется переменная, которая инициализирована  в этом классе
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood(Walls walls)
        {
            Point food;
            do
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                food = new Point(x, y, sym);
            } while (walls.IsHit(food));
            return food;
        }

        public Point CreateFood(Figure snake)
        {
            Point food;
            do
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                food = new Point(x, y, sym);
            } while (snake.IsHit(food));
            return food;
        }
    }
}
