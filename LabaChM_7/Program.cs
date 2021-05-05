using System;
using LabaChM7_Lib;
namespace LabaChM_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вiдрiзок iнтегрування[a, b] —> (a) = ");
            double a = int.Parse(Console.ReadLine()); //2
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()); //5
            Console.Write("Eps = ");
            double eps = double.Parse(Console.ReadLine()); // 0,0001
            Sympson val = new Sympson();
            int n = 2; double rez; int i = 0;
            do
            {
                rez = Math.Abs(val.SympsonMethod(a, b, n * i) - val.SympsonMethod(a, b, n * (i + 1)));
                i++;
            } while (rez > eps);
            Console.WriteLine($"\nIntegral Value with eps: {eps} = {val.SympsonMethod(a, b, n * (i))}");
            Console.WriteLine($"Count of iterations: {i}");
            Console.WriteLine("\n~ Gauss method ~");
            int N = 100; double s = 0;
            for (int j = 0; j < N; j++)
            {
                s += val.gauss(a + j * (b - a) / N, a + (j + 1) * (b - a) / N, N);
            }
            Console.WriteLine($"Integral value = {s}");
        }
    }
}
