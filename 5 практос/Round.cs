using System;
using System.Collections.Generic;
using System.Text;

namespace  praktika
{
    public class Round : Circle
    {
        public override string Draw()
        {
            return string.Format("\n Фигура Круг:\nНачальная точка(X:{0},Y:{1})\n Радиус (R:{2})\n Цвет (Color:{3})",
                X, Y, Radius, Color);
        }
        public Round(int x, int y, int radius, string color) : base(x, y, radius)
        {
            Color = color;
        }

        public string Color { get; set; }
    }
}
