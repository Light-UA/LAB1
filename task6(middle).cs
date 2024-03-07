using System;

namespace DigitalClock {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Шевченко Олексій\n");

            // Введення кількості хвилин з клавіатури
            Console.Write("Введіть кількість хвилин: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Обчислення годин та хвилин
            int hours = N / 60; // Кількість годин
            int minutes = N % 60; // Кількість залишкових хвилин

            // Перевірка на перевищення 24 годин
            hours %= 24;

            // Виведення результату
            Console.WriteLine($"Електронний годинник показує: {hours:D2}:{minutes:D2}");

            Console.ReadLine();
        }
    }
}
