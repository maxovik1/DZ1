//M2.1
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] arr = { 4, 9, 16, 25, 36 };
//
//        Console.Write("Введите индекс элемента: ");
//        int i = Convert.ToInt32(Console.ReadLine());
//        double root = Math.Sqrt(arr[i]);
//        Console.WriteLine("Квадратный корень: " + root);
//
//        Console.Write("Введите первый индекс: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите второй индекс: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        double avg = (arr[a] + arr[b]) / 2;
//        Console.WriteLine("Среднее арифметическое: " + avg);
//    }
//}


//M2.2
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { -3, 4, -2, 8, 5, 10 };
//
//        Console.Write("Введите s: ");
//        int s = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите k: ");
//        int k = Convert.ToInt32(Console.ReadLine());
//
//        if (arr[s - 1] > 0)
//            Console.WriteLine("s-й элемент положительный");
//        else
//            Console.WriteLine("s-й элемент не положительный");
//
//        if (arr[k - 1] % 2 == 0)
//            Console.WriteLine("k-й элемент четный");
//        else
//            Console.WriteLine("k-й элемент нечетный");
//
//        if (arr[k - 1] > arr[s - 1])
//            Console.WriteLine("k-й элемент больше s-го");
//        else if (arr[k - 1] < arr[s - 1])
//            Console.WriteLine("s-й элемент больше k-го");
//        else
//            Console.WriteLine("элементы равны");
//    }
//}


//M2.3
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] arr = { 10, 20, 30, 40, 50 };
//
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] * 2;
//        }
//        Console.WriteLine("Увеличены в 2 раза:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//
//        Console.Write("Введите число A: ");
//        double A = Convert.ToDouble(Console.ReadLine());
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] - A;
//        }
//        Console.WriteLine("Уменьшены на A:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//
//        double first = arr[0];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] / first;
//        }
//        Console.WriteLine("Разделены на первый элемент:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }
//}


//M2.4
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] arr = { 25, 30, 45, 50, 60 };
//
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] - 20;
//        }
//        Console.WriteLine("Уменьшены на 20:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//
//        double last = arr[arr.Length - 1];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] * last;
//        }
//        Console.WriteLine("Умножены на последний элемент:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//
//        Console.Write("Введите число B: ");
//        double B = Convert.ToDouble(Console.ReadLine());
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = arr[i] + B;
//        }
//        Console.WriteLine("Увеличены на B:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }
//}


//M2.5
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
//        int sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum = sum + arr[i];
//        }
//        Console.WriteLine("Сумма всех элементов: " + sum);
//
//        int mult = 1;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            mult = mult * arr[i];
//        }
//        Console.WriteLine("Произведение всех элементов: " + mult);
//
//        int sumSquares = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sumSquares = sumSquares + arr[i] * arr[i];
//        }
//        Console.WriteLine("Сумма квадратов: " + sumSquares);
//
//        int sumSix = 0;
//        for (int i = 0; i < 6; i++)
//        {
//            sumSix = sumSix + arr[i];
//        }
//        Console.WriteLine("Сумма шести первых: " + sumSix);
//
//        Console.Write("Введите k1: ");
//        int k1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите k2: ");
//        int k2 = Convert.ToInt32(Console.ReadLine());
//        int sumK = 0;
//        for (int i = k1 - 1; i < k2; i++)
//        {
//            sumK = sumK + arr[i];
//        }
//        Console.WriteLine("Сумма с k1 по k2: " + sumK);
//
//        double avgAll = (double)sum / arr.Length;
//        Console.WriteLine("Среднее арифметическое всех: " + avgAll);
//
//        Console.Write("Введите s1: ");
//        int s1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите s2: ");
//        int s2 = Convert.ToInt32(Console.ReadLine());
//        int sumS = 0;
//        int count = 0;
//        for (int i = s1 - 1; i < s2; i++)
//        {
//            sumS = sumS + arr[i];
//            count++;
//        }
//        double avgS = (double)sumS / count;
//        Console.WriteLine("Среднее арифметическое с s1 по s2: " + avgS);
//    }
//}


//M3.1
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { -5, 10, 0, 150, 99, 100, -20, 50 };
//
//        Console.WriteLine("Неотрицательные:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] >= 0)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//
//        Console.WriteLine("Не превышающие 100:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] <= 100)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//    }
//}


//M3.2
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 4, 7, 10, 15, 20, 33, 50, 0, 100 };
//
//        Console.WriteLine("Четные элементы:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % 2 == 0)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//
//        Console.WriteLine("Оканчивающиеся нулем:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % 10 == 0)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//    }
//}


//M3.3
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 5, 12, 150, 999, 10, 77, 1000, 45, 300 };
//
//        Console.WriteLine("Двузначные:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] >= 10 && arr[i] <= 99)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//
//        Console.WriteLine("Трехзначные:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] >= 100 && arr[i] <= 999)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//        Console.WriteLine();
//    }
//}


//M3.4
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
//
//        Console.WriteLine("Второй, четвертый и т.д.:");
//        for (int i = 1; i < arr.Length; i = i + 2)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//
//        Console.WriteLine("Третий, шестой и т.д.:");
//        for (int i = 2; i < arr.Length; i = i + 3)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        Console.WriteLine();
//    }
//}


//M4.1
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 5, 25, 10, 30, 15, 20 };
//
//        int sum1 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] <= 20)
//            {
//                sum1 = sum1 + arr[i];
//            }
//        }
//        Console.WriteLine("Сумма не превышающих 20: " + sum1);
//
//        Console.Write("Введите число a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int sum2 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] > a)
//            {
//                sum2 = sum2 + arr[i];
//            }
//        }
//        Console.WriteLine("Сумма больших a: " + sum2);
//    }
//}


//M4.2
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
//        int sum1 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % 2 != 0)
//            {
//                sum1 = sum1 + arr[i];
//            }
//        }
//        Console.WriteLine("Сумма нечетных: " + sum1);
//
//        Console.Write("Введите число: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum2 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % n == 0)
//            {
//                sum2 = sum2 + arr[i];
//            }
//        }
//        Console.WriteLine("Сумма кратных заданному числу: " + sum2);
//
//        Console.Write("Введите a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите b: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        int sum3 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % a == 0 || arr[i] % b == 0)
//            {
//                sum3 = sum3 + arr[i];
//            }
//        }
//        Console.WriteLine("Сумма кратных a или b: " + sum3);
//    }
//}


//M4.3
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 10, 30, 5, 50, 15, 25 };
//
//        int sum1 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] > 20)
//            {
//                sum1 = sum1 + arr[i];
//            }
//        }
//        if (sum1 > 100)
//        {
//            Console.WriteLine("Верно, сумма элементов больше 20 превышает 100");
//        }
//        else
//        {
//            Console.WriteLine("Неверно");
//        }
//
//        int sum2 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] < 50)
//            {
//                sum2 = sum2 + arr[i];
//            }
//        }
//        if (sum2 % 2 == 0)
//        {
//            Console.WriteLine("Верно, сумма элементов меньше 50 четная");
//        }
//        else
//        {
//            Console.WriteLine("Неверно");
//        }
//    }
//}


//M4.4
//using System;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 5, 10, 5, 20, 15, 5 };
//
//        int last = arr[arr.Length - 1];
//        int count1 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] != last)
//            {
//                count1++;
//            }
//        }
//        Console.WriteLine("Количество отличных от последнего: " + count1);
//
//        Console.Write("Введите a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int count2 = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % a == 0)
//            {
//                count2++;
//            }
//        }
//        Console.WriteLine("Кол