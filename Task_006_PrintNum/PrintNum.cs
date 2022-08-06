Console.Clear();
Console.Write("Введите пожалуйста число: ");
string number1 = Console.ReadLine();
int number2;
if (int.TryParse(number1, out int output))
{
    number2 = Convert.ToInt32(number1);
    if (number2 >= 0)
    {
        Console.Write("Ваш результат: ");
        for (int i = -number2; i < (number2 + 1); i++) 
        {
            Console.Write(i + ", ");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное число!");
    }
}
else 
{
    Console.WriteLine("Вы ввели не число!");
}
