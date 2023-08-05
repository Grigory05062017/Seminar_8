// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] Create2dArray (int rows, int collumns)
{
    int [,] createdArray = new int[rows, collumns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
        createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}

void ShowArray (int [,] showedArray)
{
    for (int i = 0; i < showedArray.GetLength(0); i++)
    {
        for (int j = 0; j < showedArray.GetLength(1); j++)
        {
        Console.Write (showedArray[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void SumRow (int [,] array)
{
    int [] sumRowArray = new int [array.GetLength(0)];
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i,j];   
                }
            sumRowArray[i] = sum;
        }
    int min = sumRowArray[0];
    int numbersRow = 1;
    for (int v = 0; v < sumRowArray.Length; v++)
    {
        if (sumRowArray[v] < min) 
        {
            min = sumRowArray[v];
            numbersRow = v + 1;
        }

    }
    Console.Write($"Минимальная строка {numbersRow}");
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int collumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] firstTaskArray = Create2dArray(rows,collumns);
ShowArray(firstTaskArray);
SumRow(firstTaskArray);
