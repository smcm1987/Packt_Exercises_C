using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Shape
    {
        private readonly int Height;
        private int Width;
        private decimal Area;

        public Shape()
        {
            Height = 0;
            Width = 0;
            Area = 0M;
        }

        public Shape(int heigth, int width)
        {
            Height = heigth;
            Width = width;
            Area = heigth * width;
        }
    }
}
