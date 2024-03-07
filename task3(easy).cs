using System;

namespace BakeryPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шевченко Олексій\n");

            // Введення даних з клавіатури
            Console.Write("Введіть ціну булочки у гривнях: ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть ціну булочки у копійках: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть кількість булочок: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Обчислення загальної вартості у гривнях та копійках
            double totalCostInHrn = X * N;
            int totalCostInMonet = Y * N;

            // Переведення копійок у гривні, якщо потрібно
            if (totalCostInMonet >= 100)
            {
                totalCostInHrn += totalCostInMonet / 100;
                totalCostInMonet %= 100;
            }

            // Вивід результату
            Console.WriteLine($"\nЗа {N} булочок необхідно заплатити {totalCostInHrn} гривень {totalCostInMonet} копійок.");

            Console.ReadLine();
        }
    }
}

