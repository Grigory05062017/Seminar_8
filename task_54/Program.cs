// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowArray (int [,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int t =0; t < array.GetLength(1) - 1; t++)
                if (array[i,t] < array[i,t+1])
                {
                   temp = array[i,t+1];
                   array[i,t+1] = array[i,t];
                   array[i,t] = temp;
                }
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int collumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] firstTaskArray = Create2dArray(rows,collumns);
ShowArray(firstTaskArray);
SortRowArray(firstTaskArray);
ShowArray(firstTaskArray);