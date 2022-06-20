using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_16122020
{
    class Circle : Values, ICalculate

    {
        public double getArea(double radius)
        {
            this.radius = radius;
            area = PI * radius * radius;

            return area;
        }
    }
}
