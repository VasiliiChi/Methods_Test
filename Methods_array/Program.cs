using System;

namespace Methods_array
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
            Console.ReadKey();
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива № {0}", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nЭлементы в массиве: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            return result;
        }
    }

}
