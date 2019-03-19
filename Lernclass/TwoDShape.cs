using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class TwoDShape
    {
        public int s;
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public TwoDShape()
        {

        }
        public TwoDShape (double x)
        {
            Width = Height = x;
        }
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
        }
        public void showDim()
        {
            Console.WriteLine("Ширина и высота равны "+ width +" и " +height);
        }


    }
}
