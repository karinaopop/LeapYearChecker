using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введіть рік (або 0 для виходу): ");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int year))
            {
                Console.WriteLine("Введіть коректне число.\n");
                continue;
            }

            if (year == 0)
            {
                Console.WriteLine("Вихід з програми...");
                break;
            }

            if (IsLeapYear(year))
                Console.WriteLine($"{year} рік — високосний.\n");
            else
                Console.WriteLine($"{year} рік — не високосний.\n");
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
