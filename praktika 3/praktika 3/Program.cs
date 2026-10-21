using System;

class Triangle
{
    public int Biba { get; set; }
    public int Boba { get; set; }
    public int Aboba { get; set; }

    public Triangle(int biba, int boba, int aboba) => (Biba, Boba, Aboba) = (biba, boba, aboba);

    public void Print() => Console.WriteLine($"biba={Biba}, boba={Boba}, aboba={Aboba}");

    public double P() => Biba + Boba + Aboba;

    // Площадь по формуле Герона
    public double S()
    {
        if (!Valid) return 0;
        double p = P() / 2;
        return Math.Sqrt(p * (p - Biba) * (p - Boba) * (p - Aboba));
    }

    // Проверка существования треугольника
    public bool Valid => Biba + Boba > Aboba && Biba + Aboba > Boba && Boba + Aboba > Biba;

    // Индексатор 0,1,2 -> стороны
    public int this[int i]
    {
        get => i switch { 0 => Biba, 1 => Boba, 2 => Aboba, _ => throw new IndexOutOfRangeException() };
        set => _ = i switch { 0 => Biba = value, 1 => Boba = value, 2 => Aboba = value, _ => throw new IndexOutOfRangeException() };
    }

    // ++ и -- изменение сторон на 1
    public static Triangle operator ++(Triangle t) { t.Biba++; t.Boba++; t.Aboba++; return t; }
    public static Triangle operator --(Triangle t) { t.Biba--; t.Boba--; t.Aboba--; return t; }

    public static bool operator true(Triangle t) => t.Valid;
    public static bool operator false(Triangle t) => !t.Valid;

    // умножение сторон на скаляр
    public static Triangle operator *(Triangle t, int k) => new Triangle(t.Biba * k, t.Boba * k, t.Aboba * k);
}

class Program
{
    static void Main()
    {
        var t = new Triangle(3, 4, 5);
        t.Print();
        Console.WriteLine($"P={t.P()}, S={t.S():F2}, Valid={t.Valid}");
        t++; t.Print();
        (t * 2).Print();
    }
}