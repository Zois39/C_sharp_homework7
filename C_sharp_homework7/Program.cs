//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] CreatDouble2DArray(int m, int n)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
    return result;
}

void Show2DArray (double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
}

int ReadNumber(string str)
{
    Console.WriteLine($"Input number of {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int row = ReadNumber("row");
int column = ReadNumber("column");

Show2DArray(CreatDouble2DArray(row, column));
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 > такого числа в массиве нет

/*
int[,] Creat2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = new Random().Next(-100, 100);
    return result;
}

int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int[,] arr = Creat2DArray(row, column);

int ReadNumber(string str)
{
    Console.WriteLine($"Input number of {str}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int findRow = ReadNumber("find row");
int findColumn = ReadNumber("find column");

if(findRow > row - 1 || findColumn > column - 1)
    Console.WriteLine("такого числа в массиве нет");
else
    Console.WriteLine(arr[findRow, findColumn]);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] Creat2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = new Random().Next(0, 100);
    return result;
}

int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int[,] arr = Creat2DArray(row, column);
double avg = 0;
for(int i = 0; i < arr.GetLength(1); i++)
{
    for(int j = 0; j < arr.GetLength(0); j++)
        avg += Convert.ToDouble(arr[j, i]);
    Console.Write(avg / arr.GetLength(0) + " ");
    avg = 0;
}
*/