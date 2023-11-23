
using System.Net.Http.Headers;

namespace Lab_1.Task_4
{
    public class Program
    {
        public static void Main()
        {
            string html = Grad();
            
            // Записываем строку в файл
            File.WriteAllText("Task-4.html", html);
        }

        public static string Grad()
        {
            string ret = "";
            // Записываем в строку столько тэгов, сколько достаточно для плавного градиента от белого к черному
            for (int i = 255; i >= 0; i--) ret += $"<div style=\"background-color:rgb({i}, {i}, {i}); color:rgb({i}, {i}, {i});\">{i}</div>";
            return ret;
        }
    }
}
