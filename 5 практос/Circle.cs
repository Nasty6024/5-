using System;
using System.Collections.Generic;
using System.Text;

namespace praktika
{
    public class Circle : Figure
    {

        public Circle(int x, int y, int radius) : base(x, y)//Создаем конструктор,чтоб наследовать начальные точки
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public override string Draw()
        {
            return string.Format("\n Фигура окружность: \n Начальная точка(Х:{0},У:{1}) \n Радиус(R:{2})",
                X, Y, Radius);
        }
    }
}

