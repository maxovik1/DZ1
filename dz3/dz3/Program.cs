//Задание 1
//using System;
//
//class Program
//{
//    static int SumMinMax(int a, int b, int c)
//    {
//        int min = a;
//        if (b < min) min = b;
//        if (c < min) min = c;
//
//        int max = a;
//        if (b > max) max = b;
//        if (c > max) max = c;
//
//        return min + max;
//    }
//
//    static void Main(string[] args)
//    {
//        Console.Write("Введите первое число: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите второе число: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите третье число: ");
//        int c = Convert.ToInt32(Console.ReadLine());
//
//        int result = SumMinMax(a, b, c);
//        Console.WriteLine("Сумма большего и меньшего: " + result);
//    }
//}


//Задание 2
//using System;
//
//class Program
//{
//    static int SumDividers(int num)
//    {
//        int sum = 0;
//        for (int i = 1; i <= num; i++)
//        {
//            if (num % i == 0)
//            {
//                sum = sum + i;
//            }
//        }
//        return sum;
//    }
//
//    static void Main(string[] args)
//    {
//        Console.Write("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//
//        int maxNum = 2;
//        int maxSum = SumDividers(2);
//
//        for (int i = 3; i <= n; i++)
//        {
//            int currentSum = SumDividers(i);
//            if (currentSum > maxSum)
//            {
//                maxSum = currentSum;
//                maxNum = i;
//            }
//        }
//
//        Console.WriteLine("Число с максимальной суммой делителей: " + maxNum);
//    }
//}


//Задание 3
//using System;
//
//class Program
//{
//    static int NOD(int a, int b)
//    {
//        while (b != 0)
//        {
//            int temp = b;
//            b = a % b;
//            a = temp;
//        }
//        return a;
//    }
//
//    static bool IsMutuallySimple(int a, int b, int c)
//    {
//        int nod = NOD(a, b);
//        nod = NOD(nod, c);
//        return nod == 1;
//    }
//
//    static void Main(string[] args)
//    {
//        Console.Write("Введите первое число: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите второе число: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите третье число: ");
//        int c = Convert.ToInt32(Console.ReadLine());
//
//        if (IsMutuallySimple(a, b, c))
//        {
//            Console.WriteLine("Числа взаимно простые");
//        }
//        else
//        {
//            Console.WriteLine("Числа не взаимно простые");
//        }
//    }
//}


//Задание 4
//using System;
//
//class Program
//{
//    static double SredGeom(double a, double b, double c)
//    {
//        return Math.Pow(Math.Abs(a) * Math.Abs(b) * Math.Abs(c), 1.0 / 3.0);
//    }
//
//    static double SredArif(double x, double y)
//    {
//        return (x + y) / 2;
//    }
//
//    static void Main(string[] args)
//    {
//        Console.Write("Введите первое число: ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Введите второе число: ");
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Введите третье число: ");
//        double c = Convert.ToDouble(Console.ReadLine());
//
//        double geom = SredGeom(a, b, c);
//        Console.WriteLine("Среднее геометрическое модулей: " + geom);
//
//        Console.WriteLine("Среднее арифметическое a и b: " + SredArif(a, b));
//        Console.WriteLine("Среднее арифметическое a и c: " + SredArif(a, c));
//        Console.WriteLine("Среднее арифметическое b и c: " + SredArif(b, c));
//    }
//}


//Задание 5
//using System;
//
//class Program
//{
//    static double CircleArea(double r)
//    {
//        return Math.PI * r * r;
//    }
//
//    static void Main(string[] args)
//    {
//        Console.Write("Введите радиус: ");
//        double r = Convert.ToDouble(Console.ReadLine());
//        double s = CircleArea(r);
//        Console.WriteLine("Площадь круга: " + s);
//    }
//}


//Задание 6
//using System;
//
//class Program
//{
//    static double Trace(int[,] matrix)
//    {
//        double sum = 0;
//        int n = matrix.GetLength(0);
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + matrix[i, i];
//        }
//        return sum;
//    }
//
//    static void Main(string[] args)
//    {
//        int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//        int[,] B = { { 2, 0 }, { 1, 3 } };
//
//        double c = Trace(A);
//        double d = Trace(B);
//
//        Console.WriteLine("c = " + c);
//        Console.WriteLine("d = " + d);
//        Console.WriteLine("x\t\ty");
//
//        for (double x = 0; x <= 1; x = x + 0.1)
//        {
//            double y = c * x * x + d;
//            Console.WriteLine(Math.Round(x, 1) + "\t\t" + y);
//        }
//    }
//}