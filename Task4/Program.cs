namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название папки: ");
            string folderName = Console.ReadLine();

            Console.Write("Введите название части файла: ");
            string fileNamePart = Console.ReadLine();

            string[] files = Directory.GetFiles(folderName, "*", SearchOption.AllDirectories)
                .Where(file => Path.GetFileName(file).Contains(fileNamePart))
                .Select(file => Path.GetFileName(file) + " - " + new FileInfo(file).Length)
                .ToArray();

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
