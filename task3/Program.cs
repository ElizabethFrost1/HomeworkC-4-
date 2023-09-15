// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int size = GetNumber("Введите размер массива: ");
int min = GetNumber("Введите минимальное значение в массиве: ");
int max = GetNumber("Введите максимальное значение в массиве: ");


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
Random rand = new Random();
for(int index =0; index < size; index++)
{
    array[index] = rand.Next(min, max);
}
return array;
}
void Print(int[]arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
    Console.Write($"{arr[i]} ");

    }
}
Print(GetArray(size, min, max));

