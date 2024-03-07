using System;

namespace MinutesToHours {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Шевченко Олексій\n");

            Console.Write("Введіть кількість хвилин: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int hours = minutes / 60;
            int remainingMinutes = minutes % 60;

            Console.WriteLine($"\nРезультат: {hours}:{remainingMinutes:D2}");

            Console.ReadLine();
        }
    }
}
