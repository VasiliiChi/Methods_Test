using System;

namespace GetName
{
    class Program
    {
        static void Main(string[] args)
        {
            var someName = "Евгения";
            Console.WriteLine(someName);
            var someAge = 22;
            Console.WriteLine(someAge);

            GetName(someName);
            Console.WriteLine(someName);

            GetAge(someAge);
            Console.WriteLine(someAge);

            Console.ReadKey();
        }
        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void GetAge(int age)
        {
            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());
        }
    }
}
