using System;

namespace SeriesSumAboba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод значения ε
            Console.Write("Введите значение ε (aboba) (например, 0.0001): ");
            string aboba_input = Console.ReadLine();

            // Проверка корректности ввода
            if (!double.TryParse(aboba_input, out double aboba) || aboba <= 0)
            {
                Console.WriteLine("Ошибка: aboba должно быть положительным числом.");
                return;
            }

            //biba - сумма, boba - счетчик n
            double biba = 0.0;
            int boba = 1;

            //Основной цикл
            while (true)
            {
                //Вычисляем модуль текущего члена ряда: |a_n| = 1 / n^n
                double abibas = 1.0 / Math.Pow(boba, boba);

                //Если модуль члена меньше aboba, прекращаем цикл
                if (abibas < aboba)
                {
                    break;
                }

                //Вычисляем знак: bibas
                double bibas = (boba % 2 != 0) ? 1.0 : -1.0;

                //Вычисляем сам член ряда: bobas
                double bobas = bibas * abibas;

                //Добавляем к сумме (biba) и увеличиваем счетчик (boba)
                biba += bobas;
                boba++;
            }

            //Вывод результата
            Console.WriteLine($"\nСумма членов ряда, модуль которых >= {aboba}:");
            Console.WriteLine($"Сумма (biba) = {biba}");
            Console.WriteLine($"Количество учтенных членов ряда: {boba - 1}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}