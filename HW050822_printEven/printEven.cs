Console.Clear();
Console.Write("Введите пожалуйста число: ");
string number1 = Console.ReadLine();
int i = 2;
if (Double.TryParse(number1, out double number))
{
    int number2 = Convert.ToInt32(number);
    if (number2 > 1)
    {
        Console.Write("Четные числа: ");
        while (i <= number2)
        {
            Console.Write(i + ", ");
            i += 2;
        }
    }
    else 
    {
        Console.WriteLine("Вы ввели отрицательное число или меньшее 1.999999!");
    }
}
else 
{
    Console.WriteLine("Вы ввели не число!");
}