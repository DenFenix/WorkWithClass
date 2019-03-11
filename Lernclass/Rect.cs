using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Rect
    {
        int width;
        int height;
        public Rect(int w, int h)
        {
            width = w;
            height = h;

        }
        public int area()
        {
            return width * height;
        }
        public void show()
        {
            Console.WriteLine(width + " "+ height);
        }
        /*Метод влзвращает прямоугольник, который увеличен по
         сравнению с вызывающим объектом прямоугольника с 
         использованием заддоного коэфициента увеличения*/
        public Rect enlarge(int factor)
        {
           return new Rect(width * factor, height * factor); //кроме вызова коструктора в таком случае нужно доабвить new
        }
    }
}
