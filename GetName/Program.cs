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

            GetName(ref someName);
            Console.WriteLine(someName);

            GetAge(someAge);
            Console.WriteLine(someAge);

            var arr = new int[] { 1, 2, 3 };
            var data = 5;
            BigDataOperation(arr, in data);

            Console.WriteLine(arr[0]);

            Console.ReadKey();
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void GetAge(int age)
        {
            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());
        }

        static void BigDataOperation(int[] arr, in int data)
        {
            //data = 4;  будет ошибка, так как in запрещает менять данные в методе
            arr[0] = data;
        }
    }
}
