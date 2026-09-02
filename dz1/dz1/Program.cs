//№1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int biba = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int boba = Convert.ToInt32(Console.ReadLine());

        if (biba == boba)
        {
            Console.WriteLine("Два числа равны");
        }
        else if (biba > boba)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
}


