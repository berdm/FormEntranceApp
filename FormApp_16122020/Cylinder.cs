using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_16122020
{
    class Cylinder : Values, ICalculate
    {
        public double h;
        public double getArea(double radius)
        {
            this.radius = radius;
            this.height = h;
            area = 2 * PI * radius * (radius + height);

            return area;
        }
    }
}
