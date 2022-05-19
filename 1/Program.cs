namespace _1
{
    public class Program
    {
        /// <summary>
        /// Получает и возвращает от пользователя имя
        /// </summary>
        /// <returns>Имя пользователя</returns>
        public static string Name()
        {
            string str;

            while (true)
            {
                Console.Write("Введите имя: ");
                str = Console.ReadLine() ?? String.Empty;
                if (str != String.Empty) return str;
            }
        }

        /// <summary>
        /// Получает и возвращает от пользователя возраст
        /// </summary>
        /// <returns>Возраст пользователя</returns>
        public static int Age()
        {
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (int.TryParse(Console.ReadLine(), out int age) && age >= 0) return age;
            }
        }

        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Задача 1\n");

            string name = Name();
            int age = Age();

            Console.WriteLine("\nЗдравствуй, {0}. Тебе {1} лет.", name, age);
        }
    }
}