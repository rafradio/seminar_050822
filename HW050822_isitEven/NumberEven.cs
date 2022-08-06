Console.Clear();
Console.Write("Введите пожалуйста число: ");
string number1 = Console.ReadLine();
if (int.TryParse(number1, out int number))
{
    if ((number % 2) == 0)
    {
        Console.WriteLine("Данное число ЧЕТНОЕ: " + number1);
    }
    else 
    {
        Console.WriteLine("Данное число НЕЧЕТНОЕ: " + number1);
    }
}
else
{
    Console.WriteLine("Вы ввели либо строчку, либо дробное число");
}
