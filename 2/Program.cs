namespace _2
{
    public class Program
    {
        public static int Int()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out int num)) return num;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Задача 2\n");

            int num = Int();

            Console.WriteLine("\nПервое число: {0}", num);
            Console.WriteLine("Второе число: {0}", num + 1);
            Console.WriteLine("Третье число: {0}", num + 2);
            Console.WriteLine("Сумма: {0}", num * 3 + 3);
        }
    }
}