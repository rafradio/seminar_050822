using System;

namespace MaxMin
{
    class Maxmin
    {
        static int RandNumber()
        {
            int number = new Random().Next(-100, 101);
            return number;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int number1 = RandNumber();
            int number2 = RandNumber();
            if (number1 > number2)
            {
                int max = number1;
                Console.WriteLine("Первое число больше: " + max + ", а второе число меньше: " + number2);
            }
            else
            {
                int max = number2;
                Console.WriteLine("Второе число больше: " + max + ", а первое число меньше: " + number1);
            }
        }
    }

}