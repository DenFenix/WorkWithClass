using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class FailSoftArray2D
    {
        int[,] ma; //индексы в двумерном массиве
        int rows, cols;
        public int Length;
        public bool svError;
        public FailSoftArray2D(int r, int c)
        {
            ma = new int[r, c];
            Length = r * c;
            rows = r;
            cols = c;

        }
        public int this[int a, int b] //синтаксис двумерного индекса

        {
            get //возвращение
            { if (chek(a, b)) //проверка на границы
                {
                    svError = false;
                    return ma[a, b]; 
                }
                else
                    svError = true;
                return 0;

            }
            set //зваись
            {
                if (chek(a, b))
                {
                    svError = false;
                    ma[a, b] = value;
                }
                else
                    svError = true;
            }


        }
        public bool chek(int a, int b)
        {
            if ((0 <= a) && (a < rows) && (0 <= b) && (b < cols))
                return true;
            else              //можно без else тогда он не если он не выйдет в иф он выйдет в return false
                return false;
        }
    }
}
