
namespace Lab_1.Task_3
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите Длинну: ");
            float lenght;
            while (!float.TryParse(Console.ReadLine(), out lenght) || lenght <= 0)  // Проверяем на правильность введенных значений
            {
                Console.WriteLine("Ошибка ввода!!");
                Console.Write("Введите Длинну: ");
            }
            Console.Write("Введите Ширину: ");
            float width;
            while (!float.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Ошибка ввода!!");
                Console.Write("Введите Ширину: ");
            }

            Console.WriteLine(S(lenght, width));
        }

        public static float S(float a, float b)
        {
            return a * b;
        }
    }
}

