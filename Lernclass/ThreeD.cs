using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class ThreeD
    { int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }
        public ThreeD(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public static ThreeD operator |(ThreeD ob1, ThreeD ob2)
        {
            
            if (((ob1.x != 0) || (ob1.y != 0) || (ob1.z != 0)) |
                         ((ob2.x != 0) || (ob2.y != 0) || (ob2.z != 0))) //почему ||?
                return new ThreeD(1,1,1);
            else
                return new ThreeD(0,0,0);

        }
        public static ThreeD operator &(ThreeD ob1, ThreeD ob2)
        {
            
            if (((ob1.x != 0) && (ob1.y != 0) && (ob1.z != 0)) &
                         ((ob2.x != 0) && (ob2.y != 0) && (ob2.z != 0)))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);

        }

        /* public static bool operator !(ThreeD ob1)
         {
             if ((ob1.x != 0) || (ob1.y != 0) || (ob1.z != 0))
                 return false;
             else
                 return true;

         }*///более оптимальный вариант
        public static bool operator !(ThreeD ob1)
        {
            if (ob1)
                return false;
            else
                return true;
         }



        public static bool operator true (ThreeD ob1)
        {
            if ((ob1.x != 0) || (ob1.y != 0) || (ob1.z != 0))
                return true;
            else
                return false;
        }
        public static bool operator false(ThreeD ob1)
        {
            if ((ob1.x == 0) && (ob1.y == 0) && (ob1.z == 0))
                return true;
            else
                return false;
        }
        //неявное преобразование в int
        /*public static implicit operator int(ThreeD ob1)
        {
            return ob1.x * ob1.y * ob1.z;
        }*/
        //явное преобращзование в int
        public static explicit operator int(ThreeD ob1)
        {
            return ob1.x * ob1.y * ob1.z;
        }


    }
}
