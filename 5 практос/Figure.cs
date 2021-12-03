using System;
using System.Collections.Generic;
using System.Text;

namespace praktika
{
    public abstract class Figure
    {
        //Создаём начальные точки
        public int X { get; set; }
        public int Y { get; set; }
        public abstract string Draw();

        //Создаём канструктор чтоб в Х и У загрузить значения
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
