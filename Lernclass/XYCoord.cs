using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class XYCoord
    {
        public int x, y;
        //благодаря this мы избегаем ненужного дублирования кода, благодаря ему моджно задавать параметры по умолчанию
        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("Внутри конструктора XYCoord()");
        }

        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("Вунтри конструктора XYCoord(obj)");
        }
        public XYCoord(int i, int j) //конструктор который реально инициализирует члены, все остальные на него ссылаются с помощью this
        {
            Console.WriteLine("Внутри конструктора XYCoord(int, int)");
            x = i;
            y = j;
        }
    }
}
