using System;

namespace RafailAbd
{
    class MaxFromThree 
    {
        static int[] FillArray()
        {
            int[] collection = new int[3];
            for (int y = 0; y < 3; y++)
            {
                collection[y] = new Random().Next(-100, 101);
            }      
            return collection;
        }
        static int FindMax(int[] collection)
        {
            int max = collection[0];
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] > max)
                {
                    max = collection[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int[] number = new int[3];
            number = FillArray();
            int max = FindMax(number);
            Console.WriteLine("Были случайно выбраны три числа: " + number[0] + " " + number[1] + " " + number[2]);
            Console.WriteLine("Мксимальное среди них: " + max);
        }
    }
}