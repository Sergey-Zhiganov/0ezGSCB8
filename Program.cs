namespace Практическая
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер программы:");
            Console.WriteLine("1 - Угадай число");
            Console.WriteLine("2 - Таблица умножения");
            Console.WriteLine("3 - Делители числа");
            Console.WriteLine("4 - Выйти из программы");
            Console.Write("Номер программы: ");
            string choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    First();
                    break;
                case "2":
                    Second();
                    break;
                case "3":
                    Third();
                    break;
                case "4":
                    return;
            }
            Main();
        }
        static void First()
        {
            Random value = new();
            int number1 = value.Next(100);
            int number2 = -1;
            int attempt = 0;
            while (number1 != number2)
            {
                Console.Write("Число: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > number2)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                attempt++;
            }
            Console.WriteLine($"Число {number1} отгадано за {attempt} попыток");
        }
        static void Second()
        {
            string[,] table = new string[10, 10];
            for (int x = 0; x < table.GetLength(0); x++)
            {
                for (int y = 0;  y < table.GetLength(1); y++)
                {
                    table[x,y] = ((x + 1) * (y + 1)).ToString();
                }
            }
            for (int x = 0; x < table.GetLength(0); x++)
            {
                for (int y = 0; y < table.GetLength(1); y++)
                {
                    Console.Write(table[x,y] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Third()
        {
            Console.Write("Число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    list.Add(i);
                }
            }
            Console.Write($"Делители числа {x}: ");
            foreach (int i in list)
            {
                Console.Write(i);
                if (i != list[list.Count -1])
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}