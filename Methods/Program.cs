using System;

namespace Methods
{
    class Program
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1}. \nНапишите свой любимый цвет на английском с маленькой буквы.", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;

            
        }

        static void ShowColors(string username, params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var item in favcolors)
            {
                Console.Write(item + ", ");
            }

        }
        static void Main(string[] args)
        {
            
            
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
            Console.WriteLine("Цикл for");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                ShowColor(anketa.name, anketa.age);
            }

            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);
                ShowColor(anketa.name, anketa.age);
                k++;
            }

            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);
                t++;
                ShowColor(anketa.name, anketa.age);
            } while (t < 3);



            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(anketa.name, anketa.age);
            }
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var colors in favcolors)
            {
                Console.WriteLine(colors);
            }

            ShowColors(anketa.name, favcolors);
            
            Console.ReadKey();
        }
    }

}
