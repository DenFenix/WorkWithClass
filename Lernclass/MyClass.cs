using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{ //использование фабрики класса
    class MyClass
    {
        int a, b;//закрытые члены

        //создаём фабрику класса для класса MyClass
        public MyClass factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; //Метод возвращает объект
           
        }
        public void show()
        {
            Console.WriteLine("a и b:" +a+" "+b);
        }
    }
}
