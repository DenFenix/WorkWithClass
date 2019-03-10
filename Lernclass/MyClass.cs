using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class MyClass
    {
        //примеры 
        /*public string errMsg;
        private double bal;
        private bool isError(byte statys)
        {
        }*/
        //Сравнение доступа к открытым и закрытым членам класса
        private int alpha; //явно задан спецификатор приват, чтобы не давать доступ непосредственно к переменной, ммоджно создать метод, который бы получал доступ к этой переменной
        int beta; //private по умолчанию
        public int gamma;//явно задан спецификатор public
                         //методы для получения доступа к alfa и beta

        public void SetAlpha(int a)//метол записи значения в приватную перменню
        {
            alpha = a;
        }

        public int GetAlpha()
        {
            return alpha;
        }

    }
}
