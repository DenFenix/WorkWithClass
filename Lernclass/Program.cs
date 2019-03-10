using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //управление доступом осуществляется  public, private, protected, internal
            //public  разрешает доступ разрешает доступ к члену откуда угодно
            //private разрешает доступ к члену только для методов внури этого класса
            //первый пример set, ger к приватной переменной

            MyClass firsttime = new MyClass();
            //не видит переменнойальфа
            firsttime.SetAlpha(6);
            Console.WriteLine(firsttime.GetAlpha());
             

        }
    }
}
