Console.Clear();
Console.Write("Введите пожалуйста первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пожалуйста второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine("Второе число является квадратом первого числа");
}
else 
{
    Console.WriteLine("Ни первое, ни Второе число не являются квадратом.");
}