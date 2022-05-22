using System;

namespace _3
{
    public class Program
    {
        public static double Double(string message)
        {
            while (true)
            {
                Console.Write(message + ": ");
                if (double.TryParse(Console.ReadLine(), out double num)) return num;
            }
        }
        
        public static void Main()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Решение квадратного уравнения\n");

            double a = Double("a");
            while (a == 0) a = Double("a");
            double b = Double("b");
            double c = Double("c");

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
                Console.WriteLine("Нет корней.");
            else if (D == 0)
                Console.WriteLine("x = {0}", -b / (2 * a));
            else 
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}