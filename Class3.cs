//№4
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сумму вклада: ");
        double sum = Convert.ToDouble(Console.ReadLine());
        double percent;

        if (sum < 100)
        {
            percent = 0.05;
        }
        else if (sum >= 100 && sum <= 200)
        {
            percent = 0.07;
        }
        else
        {
            percent = 0.10;
        }

        double result = sum + (sum * percent);
        Console.WriteLine("Сумма вклада с начисленными процентами: " + result);
    }
}