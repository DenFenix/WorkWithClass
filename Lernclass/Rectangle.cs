using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{//rectangle наследует twodsharp 
    class Rectangle :TwoDShape
    {//возрвашает правду если прямоугольник квадрат

        public Rectangle()
        {
            base.s =5; //получаем переменную s базового класса
        }
        public Rectangle(int h, int w) : base(h, w)
        {
        }
        public Rectangle(Rectangle ob) : base(ob)
        {
        }

        public bool isSuare()
        {
            if (Width == Height)
                return true;
            else
                return false;
           

        }
        //находим площадь
        public double area()
        {
            return Width * Height;
        }
    }

}
