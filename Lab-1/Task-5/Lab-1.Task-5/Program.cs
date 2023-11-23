
namespace Lab_1.Task_5
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Адрес папки: ");
            string dirName = Console.ReadLine();
            Console.Write("Расширение файла: ");
            string fileName = Console.ReadLine();
            // если папка существует

            List<string> files = Search(dirName, fileName);
            int i = 0;
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        public static List<string> Search(string path, string _fileName)  // Принимает адрес папки, в которой ищутся файлы, и расширение искомого файла
        {
            List<string> files = new List<string>();
            if (Directory.Exists(path))             // Если папка существует
            {
                string[] dirs = Directory.GetDirectories(path); // Получаем все папки
                foreach (string s in dirs)
                {
                    files.AddRange(Search(s, _fileName));                       // Проверяем папки на содержимое
                }
                files.AddRange(Directory.GetFiles(path, $"*.{_fileName}").ToList());    // Получаем нужные файлы
            }
            return files;
        }
    }
}


