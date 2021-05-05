using System;

namespace LabaChM7_Lib
{
    public class Sympson
    {
        public double Y(double x)
        {
            return Math.Cos(x) / (x + 1);
        }
        public double SympsonMethod(double a, double b, int n)
        {
            double x, h, s;
            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s += 4 * Y(x);
                x += h;
                s += 2 * Y(x);
                x += h;
            }
            s = h / 3 * (s + Y(a) - Y(b));
            return s;
        }
        public double gauss(double a, double b, int N )
        {
            double x, rez = 0;
            double[] Xi = { -0.7745967, 0, 0.7745967 };
            double[] Ai = { 0.5555556, 0.8888889, 0.5555556 };
            for (int i = 0; i < 3; i++)
            {
                x = (a + b) / 2 + Xi[i] * (b - a) / 2;
                rez += Ai[i] * Y(x);
            }
            return rez * (b - a) / 2;
        }

    }
}
