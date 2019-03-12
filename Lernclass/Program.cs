using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Program
    {
        static void Main()
        {
            //управление доступом осуществляется  public, private, protected, internal
            //public  разрешает доступ разрешает доступ к члену откуда угодно
            //private разрешает доступ к члену только для методов внури этого класса
            //первый пример set, ger к приватной переменной

            /* MyClass firsttime = new MyClass();
             //не видит переменнойальфа
             firsttime.SetAlpha(6);
             Console.WriteLine(firsttime.GetAlpha());
             Console.ReadKey();*/

            //Создание стека
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch; int i;
            for (i = 0; !stk1.full(); i++)
            {
                stk1.push((char)('A'+i));
            }
            if (stk1.full())
                Console.WriteLine("Стек stk1 полон.");
            Console.Write("Содержимое стека stk1");
            while (!stk1.empty())
            {
                ch = stk1.pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (stk1.empty()) Console.WriteLine("Стек stk1 пуст.\n");


            //использование переменного количества аргументов

            Min ob = new Min();
            int min;
            int a = 10, b = 20;
            min = ob.minVal(a, b);
            Console.WriteLine("Минимум равен "+ min);

            min = ob.minVal(a, b, -1);
            Console.WriteLine("Минимум равен " + min);

            //можно так е передать int массив
            int[] mass = {1,2,3,4,5 };
            min = ob.minVal(mass);
            Console.WriteLine("Минимум равен " + min);

            //возвращение методами объектов
            Rect r1 = new Rect(4,5);
            Console.Write("Размеры прямоугольника r1: ");
            r1.show();
            //прямоугольник, который в 2ое больше прямоугольника r1
            Rect r2 = r1.enlarge(2); //заместо new Rect(width * factor, height * factor)
            Console.Write("Размеры прямоугольника r2:");
            r2.show();
            Console.WriteLine("Площадь прямоугольника r2:" + r2.area());

            /*В фабриках класса применяются классовые типы значений*/
            /*Фабрик класса  - метод который используется для построения заданного класса */

            MyClass ob2 = new MyClass();
            int ii, jj;
            //генерируем объекты с помощью фабрики класса
            for (ii = 0, jj = 10; ii < 10; ii++, jj++)
            {
               MyClass anotherOb =  ob2.factory(ii, jj); //создаём объект
                anotherOb.show();
            }
            Console.WriteLine();

            //12.03.2019
            //Вызов перегруженного конструктора с помощью ссылки this

            /*имя_конструктора (список_параметров1): this(список параметров2)
             //тело конструтора, которое может ыть пустым*/
            XYCoord t1 = new XYCoord();
            XYCoord t2  = new XYCoord(8,9);
            XYCoord t3 = new XYCoord(t2);
            Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);

            //Возвращение значений из main
            //Main(): public static int Main();
            Console.ReadKey();

        }
    }
}
