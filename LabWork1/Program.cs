//C:\Temp\ispp21\LabWork1.txt
using System.IO;

namespace LabWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                Console.WriteLine($"Содержимое файла:\n{File.ReadAllText(fileName)}");
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
        }
    }
}
