
namespace Lab_1.Task_2
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Количество: ");                              // Обозначаем сколько людей мы запишем
            int countHum;
            while (!Int32.TryParse(Console.ReadLine(), out countHum) || countHum <= 0)  // Проверяем что это натуральное число
            {
                Console.WriteLine("Ошибка ввода!!");                                    // Иначе вводим заново
                Console.Write("Введите Количество: ");
            }

            AgeHumans(countHum);
        }

        public static Hum[] GetHums(int countHum)
        {
            Hum[] hums = new Hum[countHum];
            for (int i = 0; i < countHum; i++)
            {
                hums[i] = new Hum();
                Console.Write("Фамилия: "); hums[i].LastName = Console.ReadLine();      // Вписываем личные данные людей
                Console.Write("Имя: "); hums[i].Name = Console.ReadLine();
                Console.Write("Возраст: ");
                while (!Int32.TryParse(Console.ReadLine(), out hums[i].Age) || hums[i].Age < 0) // Проверяем что это натуральное число
                {
                    Console.WriteLine("Ошибка ввода!!");
                    Console.Write("Введите Возраст: ");
                }
            }
            return hums;
        }
        public static void AgeHumans(int countHum)
        {
            Hum[] hums = GetHums(countHum);

            for (int i = 0; i < countHum; i++)      // Выводим всех людей
            {
                Console.WriteLine(hums[i]);
            }

            Console.WriteLine("Min: " + AgeMin(hums, countHum));                                   // Выводим человека с минимальным возрастом
            Console.WriteLine("Max: " + AgeMax(hums, countHum));                                   // Выводим человека с максимальным возрастом
            Console.WriteLine("Mid: " + string.Format("{0:0.00}", AgeMid(hums, countHum)));    // Выводим средний возраст
        }
        public static Hum AgeMin(Hum[] hums, int countHum)
        {
            int min = int.MaxValue, min_i = 0;           // Берем значения для отслеживания возраста
            for (int i = 0;i < countHum;i++)
            {
                if (min > hums[i].Age)
                {
                    min = hums[i].Age;
                    min_i = i;
                }
            }
            return hums[min_i];
        }
        public static Hum AgeMax(Hum[] hums, int countHum)
        {
            int max = int.MinValue, max_i = 0;           // Берем значения для отслеживания возраста
            for (int i = 0; i < countHum; i++)
            {
                if (max < hums[i].Age)
                {
                    max = hums[i].Age;
                    max_i = i;
                }
            }
            return hums[max_i];
        }
        public static float AgeMid(Hum[] hums, int countHum)
        {
            float mid = 0;           // Берем значения для отслеживания возраста
            for (int i = 0; i < countHum; i++)
            {
                mid += hums[i].Age;
            }
            return mid / countHum;
        }
    }

}
public class Hum
{
    public string LastName;
    public string Name;
    public int Age;

    public override string ToString()
    {
        return $"{LastName} {Name}: {Age}";
    }
    public override bool Equals(object? obj)
    {
        Hum? hum = obj as Hum;
        return this.LastName == hum.LastName && this.Name == hum.Name && this.Age == hum.Age;
    }
};