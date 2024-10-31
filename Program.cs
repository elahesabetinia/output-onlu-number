using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter only number(for exist press 'Q' key) ");

        while (true)
        {
            // خواندن کلید از کاربر
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // intercept: true از نمایش خودکار جلوگیری می‌کند

            // بررسی کلید وارد شده برای خروج
            if (keyInfo.Key == ConsoleKey.Q)
            {
                Console.WriteLine("\nexist from code6.");
                break;
            }

            // بررسی اینکه آیا کلید وارد شده یک عدد است
            if (char.IsDigit(keyInfo.KeyChar))
            {
                // نمایش عدد در خروجی
                Console.Write(keyInfo.KeyChar);
            }
        }
    }
}
