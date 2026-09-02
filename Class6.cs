//№7
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первое число: ");
        double biba = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double boba = Convert.ToDouble(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Результат: " + (biba + boba));
                break;
            case 2:
                Console.WriteLine("Результат: " + (biba - boba));
                break;
            case 3:
                Console.WriteLine("Результат: " + (biba * boba));
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}