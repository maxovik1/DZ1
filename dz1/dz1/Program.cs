////№1
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите сумму вклада: ");
//        decimal sum = Convert.ToDecimal(Console.ReadLine());
//        Console.Write("Введите количество месяцев: ");
//        int months = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < months; i++)
//        {
//            sum = sum + sum * 0.07m;
//        }

//        Console.WriteLine("Конечная сумма: " + sum);
//    }
//}


////№2
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите сумму вклада: ");
//        decimal sum = Convert.ToDecimal(Console.ReadLine());
//        Console.Write("Введите количество месяцев: ");
//        int months = Convert.ToInt32(Console.ReadLine());

//        int i = 0;
//        while (i < months)
//        {
//            sum = sum + sum * 0.07m;
//            i++;
//        }

//        Console.WriteLine("Конечная сумма: " + sum);
//    }
//}



////№3
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.Write(i * j + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}



////№4
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Write("Введите первое число: ");
//            int biba = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите второе число: ");
//            int boba = Convert.ToInt32(Console.ReadLine());

//            if (biba >= 0 && biba <= 10 && boba >= 0 && boba <= 10)
//            {
//                Console.WriteLine("Результат: " + (biba * boba));
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Введенные числа недопустимы");
//            }
//        }
//    }
//}