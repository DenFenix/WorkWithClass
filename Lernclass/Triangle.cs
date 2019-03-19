using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Triangle : TwoDShape
    {
        public new int s; //s скрываем из базого класса и создаем в дочернем заново
        private string style;//type triangle

        public string Style { get => style; set => style = value; }

        //Метод возвращает площадь треугольника

        public double area()
        {
            return Width * Height / 2;
        }
        
        public  void showStype()
        {
            Console.WriteLine("Треугольник" + Style);
        }
    }
}
