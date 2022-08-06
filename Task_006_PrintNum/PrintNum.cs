Console.Clear();
Console.Write("Введите пожалуйста число: ");
string number1 = Console.ReadLine();
int number2;
double number;
double checkN = 10.5463;
number2 = Convert.ToInt32(checkN);
Console.WriteLine(number2);
if (Double.TryParse(number1, out number))
{
    number2 = Convert.ToInt32(number);
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
