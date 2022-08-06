Console.Clear();
Console.Write("Введите пожалуйста трехзначное число: ");
string number1 = Console.ReadLine();
int number2;
if (int.TryParse(number1, out int output))
{
    number2 = Convert.ToInt32(number1);
    if (number2 > 0 && number1.Length == 3)
    {
        Console.WriteLine("Третий символ у вашего положительного числа - " + number1[2]);
    }
    else if (number2 < 0 && number1.Length == 4)
    {
        Console.WriteLine("Третий символ у вашего отрицательного числа - " + number1[3]);
    }
    else 
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}
else
{
    Console.WriteLine("Вы ввели не число");
}
