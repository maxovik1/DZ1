using System;

namespace Aaaaa
{
    class Student
    {
        // Свойства для чтения и записи
        public string Familiya { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Kurs { get; set; }
        public string Gruppa { get; set; }

        // Свойства только для инициализации (задаются 1 раз при создании)
        public string DateOfBirth { get; init; }
        public string Zachotka { get; init; }

        // Конструктор без параметров
        public Student()
        {
            Familiya = "Неизвестно";
            Name = "Неизвестно";
            Otchestvo = "Неизвестно";
            Address = "Неизвестно";
            Phone = "Неизвестно";
            Email = "Неизвестно";
            Kurs = 1;
            Gruppa = "Неизвестно";
            DateOfBirth = "Неизвестно";
            Zachotka = "000000";
        }

        // Конструктор с параметрами
        public Student(string familiya, string name, string otchestvo, string address,
                       string phone, string email, int kurs, string gruppa,
                       string dateOfBirth, string zachotka)
        {
            Familiya = familiya;
            Name = name;
            Otchestvo = otchestvo;
            Address = address;
            Phone = phone;
            Email = email;
            Kurs = kurs;
            Gruppa = gruppa;
            DateOfBirth = dateOfBirth;
            Zachotka = zachotka;
        }

        // Переопределение ToString()
        public override string ToString()
        {
            return $"Студент: {Familiya} {Name} {Otchestvo}\n" +
                   $"Дата рождения: {DateOfBirth}\n" +
                   $"Адрес: {Address}, Телефон: {Phone}, Email: {Email}\n" +
                   $"Курс: {Kurs}, Группа: {Gruppa}, Зачетка: {Zachotka}";
        }

        // Методы для сравнения
        public bool EqualsByFamiliya(Student other)
        {
            if (other == null) return false;
            return this.Familiya.ToLower() == other.Familiya.ToLower();
        }

        public bool EqualsByGruppa(Student other)
        {
            if (other == null) return false;
            return this.Gruppa == other.Gruppa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Студент 1: конструктор с параметрами
            Student student1 = new Student(
                "Иванов", "Иван", "Иванович",
                "ул. Пушкина, д. 1", "+79991112233", "ivanov@mail.ru",
                2, "ПИ-21", "15.05.2005", "123456"
            );

            // Студент 2: конструктор без параметров + инициализатор свойств
            Student student2 = new Student()
            {
                Familiya = "Петров",
                Name = "Петр",
                Otchestvo = "Петрович",
                DateOfBirth = "20.10.2004",
                Zachotka = "654321"
            };

            // Вывод на экран
            Console.WriteLine(student1.ToString());
            Console.WriteLine("\n--- Второй студент ---");
            Console.WriteLine(student2.ToString());

            // Сравнение
            Console.WriteLine("\n--- Сравнение ---");
            Console.WriteLine($"Одинаковая фамилия? {student1.EqualsByFamiliya(student2)}");
            Console.WriteLine($"Одинаковая группа? {student1.EqualsByGruppa(student2)}");

            Console.ReadKey();
        }
    }
}