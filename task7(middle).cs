using System;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шевченко Олексій\n");

            // Введення чотиризначного числа з клавіатури
            Console.Write("Введіть чотиризначне число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Розділення числа на окремі цифри
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            // Обчислення суми цифр
            int sum = thousands + hundreds + tens + units;

            // Виведення результатів на екран
            Console.WriteLine($"\nСума цифр числа: {sum}");
            Console.WriteLine($"Кількість тисяч: {thousands}");
            Console.WriteLine($"Кількість сотень: {hundreds}");
            Console.WriteLine($"Кількість десятків: {tens}");
            Console.WriteLine($"Кількість одиниць: {units}");

            Console.ReadLine();
        }
    }
}
