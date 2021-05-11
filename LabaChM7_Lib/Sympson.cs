using System;

namespace LabaChM7_Lib
{
    public static class Funk
    {
        public static double Y(double x)
        {
            return Math.Cos(x) / (x + 1);
        }
    }
    public class Sympson
    {
        public double SympsonMethod(double a, double b, int n) // a=2, b=5, n=10
        {
            double x, h, s;
            h = (b - a) / n; //0,3
            s = 0; //площа
            x = a + h; //х після першого кроку (і - непарне)
            while (x < b)
            {
                s += 4 * Funk.Y(x); // 4 * у [непарне]
                x += h; // і - парне
                s += 2 * Funk.Y(x); // 4 * у [парне]
                x += h;
            }
            s = h / 3 * (s + Funk.Y(a) - Funk.Y(b));
            return s;
        }

    }
}
