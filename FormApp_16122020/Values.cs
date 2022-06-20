using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp_16122020
{
    //benzer özellikteki sınıf tasarımları için 
    // abstarct ta new ile nesne yaratamayız 
 
    abstract class Values
    {
        public double radius; //yariçap
        public double height; //yükseklik
        public static double PI = 3.1415; //pı sayısı
        public double area;
    }
}
