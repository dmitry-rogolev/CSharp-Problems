using System;

namespace _4
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
            Console.WriteLine("Задача 4");
            Console.WriteLine("Решение линейного уравнение вида ax + b = 0\n");

            double a = Double("a");
            while (a == 0) a = Double("a");
            double b = Double("b");
            
            Console.WriteLine("\nx = {0}", -b / a);
        }
    }
}