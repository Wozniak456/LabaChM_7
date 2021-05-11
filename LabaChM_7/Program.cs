using System;
using LabaChM7_Lib;
namespace LabaChM_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int a = 2;
            int b = 5;
            double eps = 0.0001;
            Console.WriteLine($"Вiдрiзок iнтегрування —> x = [{a};{b}]");
            Console.WriteLine($"Задана точність еps = {eps}");
            Sympson val = new Sympson();
            int n = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nМетодом Сімпсона при n = 10:");
            Console.ResetColor();
            Console.WriteLine($"Integral = {val.SympsonMethod(a, b, n):f7}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nМетодом Гауса при m = 4");
            Console.ResetColor();
            Gauss gauss1 = new Gauss();
            Console.WriteLine($"Integral = {gauss1.gauss(a, b):f7}");
        }
    }
}
