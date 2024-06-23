namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.WriteLine("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(searchText))
                    {
                        Console.WriteLine($"Строка {i + 1}: {lines[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}
