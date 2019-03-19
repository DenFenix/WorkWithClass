using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Triangle : TwoDShape
    {
        public string style;//type triangle
        //Метод возвращает площадь треугольника

        public double area()
        {
            return width * height / 2;
        }
        
        public  void showStype()
        {
            Console.WriteLine("Треугольник" + style);
        }
    }
}
