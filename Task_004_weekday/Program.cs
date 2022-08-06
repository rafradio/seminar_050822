Console.Clear();
Console.Write("Введите пожалуйста число (от 1 до 7): ");
string number1 = Console.ReadLine();
int number2;
if (int.TryParse(number1, out int output))
{
    number2 = Convert.ToInt32(number1);
    if (number2 > 0 && number2 < 8)
    {
        Console.WriteLine("Это число " + number2);
    }
    else
    {
        Console.WriteLine("Вы ввели неправильное число - " + number2);
    }
}
else
{
    Console.WriteLine("Это не число - " + number1);
}
