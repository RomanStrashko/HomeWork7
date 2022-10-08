// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns,-10,10);
PrintArray(array);*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*Console.WriteLine("Введите номер строки: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(3,4,-10,10);
PrintArray(array);

if((rows > 3) && (colums > 4))
{
    Console.WriteLine("Такого чилса нет");
}
else
{
    Console.WriteLine($"Число заданных координат ->{array[rows,colums]}");
}*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);
Console.Write($"Среднее арифметическое элементов в столбцах -> ");
Arith();


void Arith()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / rows} ;"!);
    }
    Console.WriteLine();
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}