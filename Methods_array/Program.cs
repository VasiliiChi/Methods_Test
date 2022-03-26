using System;

namespace Methods_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole();
            SortArray(array);
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

           /* Console.Write("\nЭлементы в массиве: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            
            Console.Write("\nЭлементы в массиве после сортировки по возрастанию: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }*/
            return result;
        }
        static int[] SortArray(int[] result)
        {
            
            int item = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        (result[i], result[j]) = (result[j], result[i]);
                        /*item = result[i];
                        result[i] = result[j];
                        result[j] = item;*/
                    }
                }
            }
            return result;

        }
    }

}
