namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл с указанным названием будет создан.");
            }
            else
            {
                Console.WriteLine("Файл открыт на дозапись.");
            }

            Console.WriteLine("Введите строку (для завершения введите 'end'): ");
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                File.AppendAllText(fileName, $"{line}\n");
            }
        }
    }
}
