using System;

namespace Methods_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole(10);
            ShowArray(array);
            Console.ReadKey();
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива № {0}", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

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

        static void ShowArray(int[] array, bool sort = false)
        {
            var temp = array;
            if (sort == true)
            {
                temp = SortArray(array);
            }
            foreach (var item in temp)
            {
                Console.Write(item + " ");
            }
        }
    }

}
