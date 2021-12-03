using System;
using System.Collections.Generic;
using System.Text;

namespace praktika
{
    public class Ring : Circle
    {
        public override string Draw()
        {
            return string.Format("\n Фигура кольцо:\n Начальная точка(X:{0},Y:{1}) \n Первый радиус(R:{2}) \n Второй радиус (R:{3}",
                X,Y,Radius,Radius2);
        }
        public Ring(int x, int y,int radius,int radius2): base(x, y,radius)
        {
            Radius2 = radius2;
        }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int Radius2 { get; set; }
    }
}


