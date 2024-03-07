using System;

namespace SwapVariables {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Шевченко Олексій\n");

            // Введення з клавіатури значень для змінних a та b
            Console.Write("Введіть значення для змінної a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення для змінної b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Виведення значень змінних до обміну
            Console.WriteLine($"\nЗначення змінної a до обміну: {a}");
            Console.WriteLine($"Значення змінної b до обміну: {b}");

            // Обмін значень місцями без використання додаткових змінних
            a = a + b;
            b = a - b;
            a = a - b;

            // Виведення значень змінних після обміну
            Console.WriteLine($"\nЗначення змінної a після обміну: {a}");
            Console.WriteLine($"Значення змінної b після обміну: {b}");

            Console.ReadLine();
        }
    }
}
