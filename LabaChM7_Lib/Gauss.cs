using System;
using System.Collections.Generic;
using System.Text;

namespace LabaChM7_Lib
{
    public class Gauss
    {
        public double gauss(double a, double b)
        {
            double x, sum = 0;
            double[] Xi = { -0.861136, -0.339981, 0.339981, 0.861136 };//значення вузлів при кількість вузлів n = 4;
            double[] Ai = { 0.347855, 0.652145, 0.652145, 0.347855 };
            for (int i = 0; i < 4; i++)
            {
                x = (a + b) / 2 + Xi[i] * (b - a) / 2; //заміна х[i] через t[i] щоб змінити межі
                sum += Ai[i] * Funk.Y(x); //сума (складова добутку для знаходження інтегралу)
            }
            return sum * (b - a) / 2;
        }
    }
}
