
class Practicheskaya
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Показать таблицу умножения");
            Console.WriteLine("2. Угадай число");
            Console.WriteLine("0. Выход");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Tablitsaymnozenia();
                    break;
                case "2":
                    Ugadaichislo();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Выберите либо 1 либо 2, 0");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Tablitsaymnozenia()
    {
        var table = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                table[i - 1, j - 1] = i * j;
                Console.Write(table[i - 1, j - 1] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Ugadaichislo()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);

        Console.WriteLine("Угадай число");
        Console.WriteLine("Загадано число от 0 до 100. Угадай.");

        int chislo;

        do
        {
            Console.Write("Введите ваше число: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out chislo))
            {
                Console.WriteLine("Пожалуйста, введите целое число.");
                continue;
            }

            if (chislo < randomNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else if (chislo > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }
        } while (chislo != randomNumber);

        Console.WriteLine("Поздравляю, вы угадали число!");
    }
}
