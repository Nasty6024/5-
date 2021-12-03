using System;
using System.Collections.Generic;
using System.Text;

namespace praktika
{
    public class Line : Figure
    {

        public Line(int x, int y, int endx, int endy) : base(x, y)//Создаем конструктор,чтоб наследовать начальные точки
        {
            EndX = endx;
            EndY = endy;
        }
        //создаем свойства для конечных точек так как в линии две точки
        public int EndX { get; set; }
        public int EndY { get; set; }


        public override string Draw()
        {
            return string.Format("Фигура линия: \n Начальная точка(Х:{0},У:{1}) \n Конечная точка (X:{2},Y:{3})",
                X, Y, EndX, EndY);
        }
    }
}
