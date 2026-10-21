using System;

namespace Aaaaa
{
    class Triangle
    {
        // Стороны треугольника
        private double biba;
        private double boba;
        private double aboba;

        // Конструктор с параметрами (единственный способ создать треугольник)
        public Triangle(double biba, double boba, double aboba)
        {
            this.biba = biba;
            this.boba = boba;
            this.aboba = aboba;
        }

        // Расчет периметра
        public double CalculatePerimeter()
        {
            return biba + boba + aboba;
        }

        // Вывод длин сторон
        public void PrintSides()
        {
            Console.WriteLine($"Длины сторон: biba = {biba}, boba = {boba}, aboba = {aboba}");
        }

        // Вывод периметра
        public void PrintPerimeter()
        {
            Console.WriteLine($"Периметр треугольника: {CalculatePerimeter()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ввод сторон треугольника ===");

            // Запрашиваем первую сторону
            Console.Write("Введите сторону biba: ");
            double biba = double.Parse(Console.ReadLine());

            // Запрашиваем вторую сторону
            Console.Write("Введите сторону boba: ");
            double boba = double.Parse(Console.ReadLine());

            // Запрашиваем третью сторону
            Console.Write("Введите сторону aboba: ");
            double aboba = double.Parse(Console.ReadLine());

            // Создаем объект с введенными значениями
            Triangle triangle = new Triangle(biba, boba, aboba);

            Console.WriteLine("\n--- Результаты ---");
            triangle.PrintSides();
            triangle.PrintPerimeter();

            Console.ReadKey();
        }
    }
}