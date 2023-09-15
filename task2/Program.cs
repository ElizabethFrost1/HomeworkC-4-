// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetNumber("Введите число: ");

int length = NumberLength(number);
SumNumbers(number, length);

int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void SumNumbers(int num1, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum = sum + (num1 % 10);
        num1 = num1 / 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}


