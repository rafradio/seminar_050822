int number1 = 5;
int number2 = 10;
if (number1 > number2)
{
    int max = number1;
    Console.WriteLine("Первое число больше -" + max + ", а второе число меньше - " + number2);
}
else
{
    int max = number2;
    Console.WriteLine("Второе число больше -" + max + ", а первое число меньше - " + number1);
}