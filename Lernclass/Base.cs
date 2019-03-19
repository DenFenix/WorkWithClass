using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{//Демогнстрация виртуального метода 
    class Base
    {//создаём виртуальный метод в базовом класк
        public virtual void who() //virtual  - говорит что он виртуальный
        {
            Console.WriteLine("Метод who() в классе Base");
        }

    }
    //Переопределляем метод who() в производном классе
    class Derived1 : Base
    {
        public override void who()
        {
            Console.WriteLine("Метод who() в классе Derived1");
        }

    }
    class Derived2 : Base
    {
        //снова переопределяем метод who()
        //можное не переопределять метод who() и тогда будет вызываться базовый
        //public override void who()
        //{
        //    Console.WriteLine("Метод who() в классе Derived2");
        //}
    }
    /* Если производный класс не переопределяет виртуальный  
     * метод в случае многоуровневой иерархии, будет выполнен  
     * первый переопределенный метод, который обнаружится  при 
     * просмотре иерархической лестницы в направлении  снизу вверх. */
    class Derived3 : Derived1 //связан с Derived 1, т.е многоуровненвая
    {
       
        //можное не переопределять метод who() и тогда будет вызываться базовый
        //public override void who()
        //{
        //    Console.WriteLine("Метод who() в классе Derived2");
        //}
    }
}
