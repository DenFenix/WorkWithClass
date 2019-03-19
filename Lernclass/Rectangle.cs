using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{//rectangle наследует twodsharp 
    class Rectangle :TwoDShape
    {//возрвашает правду если прямоугольник квадрат
        public bool isSuare()
        {
            if (width == height)
                return true;
            else
                return false;
           

        }
        //находим площадь
        public double area()
        {
            return width * height;
        }
    }
}
