using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Перевірка числа на від'ємність, додатність або рівність нулю
        Console.Write("1. Введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("Число є додатнім.");
        else if (number < 0)
            Console.WriteLine("Число є від'ємним.");
        else
            Console.WriteLine("Число дорівнює нулю.");

        // 2. Перевірка на високосний рік
        Console.Write("2. Введіть рік: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine("Цей рік є високосним.");
        else
            Console.WriteLine("Цей рік не є високосним.");

        // 3. Обчислення податку на дохід
        Console.Write("3. Введіть річний дохід: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;

        if (income <= 10000)
            tax = income * 0.1;
        else if (income <= 50000)
            tax = 10000 * 0.1 + (income - 10000) * 0.2;
        else
            tax = 10000 * 0.1 + 40000 * 0.2 + (income - 50000) * 0.3;

        Console.WriteLine($"Податок на дохід: {tax}");

        // 4. Перевірка символу на голосну чи приголосну
        Console.Write("4. Введіть символ: ");
        char symbol = Console.ReadLine()[0];
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        if (char.IsLetter(symbol))
        {
            symbol = char.ToUpper(symbol);

            if (Array.IndexOf(vowels, symbol) != -1)
                Console.WriteLine("Це голосна буква.");
            else
                Console.WriteLine("Це приголосна буква.");
        }
        else
        {
            Console.WriteLine("Введений символ не є буквою.");
        }

        // 5. Визначення найбільшого з трьох чисел
        Console.Write("5. Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("   Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("   Введіть третє число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"   Найбільше число: {max}");

        // 6. Перевірка "підліткового" віку
        Console.Write("6. Введіть вік: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 12 && age <= 18)
            Console.WriteLine("Це підліток.");
        else
            Console.WriteLine("Це не підліток.");

        // 7. Визначення парності та дільності на 3 числа
        Console.Write("7. Введіть число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("   Це парне число.");
        else
            Console.WriteLine("   Це непарне число.");

        if (num % 3 == 0)
            Console.WriteLine("   Це число ділиться на 3.");
        else
            Console.WriteLine("   Це число не ділиться на 3.");

        // 8. Визначення найбільшої сторони трикутника
        Console.Write("8. Введіть сторону 'a' трикутника: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("   Введіть сторону 'b' трикутника: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("   Введіть сторону 'c' трикутника: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a >= b && a >= c)
            Console.WriteLine($"   Сторона 'a' є найдовшою.");
        else if (b >= a && b >= c)
            Console.WriteLine($"   Сторона 'b' є найдовшою.");
        else
            Console.WriteLine($"   Сторона 'c' є найдовшою.");
    }
}