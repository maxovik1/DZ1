//Задание 1

//using System;

//class biba
//{
//    public char Symbol;

//    public biba(char symbol)
//    {
//        Symbol = symbol;
//    }

//    public biba(biba other) // Конструктор копирования для biba
//    {
//        Symbol = other.Symbol;
//    }
//}

//class boba : biba
//{
//    public string Text;

//    public boba(char symbol, string text) : base(symbol) // Передаем symbol в конструктор родителя
//    {
//        Text = text;
//    }

//    public boba(boba other) : base(other) // Передаем объект в конструктор копирования родителя
//    {
//        Text = other.Text; // Копируем собственное поле
//    }
//}

//class aboba : boba
//{
//    public int Number;

//    public aboba(char symbol, string text, int number) : base(symbol, text) // Вызываем конструктор boba
//    {
//        Number = number;
//    }

//    public aboba(aboba other) : base(other) // Запускаем цепочку копирования
//    {
//        Number = other.Number;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        aboba original = new aboba('A', "Равно", 100); // Создаем оригинал
//        aboba copy = new aboba(original); // Создаем независимую копию

//        Console.WriteLine($"{copy.Symbol} {copy.Text} {copy.Number}");
//    }
//}



//Задание 3
//using System;

//class BazoviyMassiv
//{
//    protected int[] massivInt; // Защищенный массив (доступен наследникам)

//    public BazoviyMassiv(int razmer)
//    {
//        massivInt = new int[razmer];
//    }

//    public int this[int indeks] // Индексатор для int-массива
//    {
//        get { return massivInt[indeks]; }
//        set { massivInt[indeks] = value; }
//    }

//    public virtual int Razmer // Виртуальное свойство (можно заменить в наследнике)
//    {
//        get { return massivInt.Length; }
//    }
//}

//class ProizvodniyMassiv : BazoviyMassiv
//{
//    protected char[] massivChar; // Новый массив

//    public ProizvodniyMassiv(int razmerInt, int razmerChar) : base(razmerInt)
//    {
//        massivChar = new char[razmerChar];
//    }

//    public char this[char indeks] // Индексатор с символьным индексом
//    {
//        get { return massivChar[indeks]; } // 'a' автоматически станет числом 97
//        set { massivChar[indeks] = value; }
//    }

//    public new int[] Razmer // Ключевое слово new скрывает базовое свойство
//    {
//        get
//        {
//            // Возвращаем массив из двух размеров
//            return new int[] { massivInt.Length, massivChar.Length };
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ProizvodniyMassiv obekt = new ProizvodniyMassiv(5, 10);

//        obekt[0] = 100;       // Обращаемся к базовому int-массиву
//        obekt['a'] = 'X';     // Обращаемся к char-массиву (индекс 97)

//        Console.WriteLine("Znachenie int: " + obekt[0]);
//        Console.WriteLine("Znachenie char: " + obekt['a']);

//        int[] razmery = obekt.Razmer; // Получаем массив с двумя размерами
//        Console.WriteLine($"Razmer int massiva: {razmery[0]}, Razmer char massiva: {razmery[1]}");
//    }
//}