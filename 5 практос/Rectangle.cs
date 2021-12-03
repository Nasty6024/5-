using System;
using System.Collections.Generic;
using System.Text;

namespace praktika
{
    public class Rectangle : Figure
    {
        public override string Draw()
        {
            return string.Format("\n Фигура прямоугольник:\n Первая точка (X:{0},Y:{1})  \n Вторая точка (X2:{2},Y2:{1}) \nТретья точка (X3:{2},Y3:{3}) \nЧетвёртая точка (X4:{0},Y4:{3}",
               X, Y, X2, Y2);
        }
        public Rectangle(int x, int y, int x2, int y2) : base(x, y)
        {
            X2 = x2;
            Y2 = y2;
        }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }

    }
}