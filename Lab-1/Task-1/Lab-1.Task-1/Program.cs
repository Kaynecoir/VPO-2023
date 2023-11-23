
namespace Lab_1.Task_1
{
    public class Program
    {
        public static string Print(int count_i)
        {
            string ret = "";
            ret += "Hello, World!\n";             // Пишем Hello, World!
            ret += "Andhiagain!\n";               // Пишем Andhiagain!

            for (int i = 0; i < count_i; i++)    // Пишем ! 
            {
                ret += "!";
            }
            return ret;
        }

        public static void Main()
        {
            Random random = new Random();                   // Получаем случайное значение от 5 до 50
            Console.WriteLine(Print(random.Next(5, 50)));
        }
    }
}
