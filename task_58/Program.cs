// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] Create1Matrix (int rows1, int collumns1)
{
    int [,] createdArray = new int[rows1, collumns1];
    for (int i = 0; i < rows1; i++)
        for (int j = 0; j < collumns1; j++)
        createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}

int [,] Create2Matrix (int rows2, int collumns2)
{
    int [,] createdArray = new int[rows2, collumns2];
    for (int i = 0; i < rows2; i++)
        for (int j = 0; j < collumns2; j++)
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

int [,] MatrixCom (int[,] Create1Matrix, int[,] Create2Matrix)
{
    int [,] finMatrix = new int [Create1Matrix.GetLength(0),Create2Matrix.GetLength(1)];

    for (int i = 0; i < Create1Matrix.GetLength(0); i++)
        for (int j = 0; j < Create2Matrix.GetLength(1); j++)
            for (int w = 0; w < Create2Matrix.GetLength(0); w++)
              finMatrix[i,j] = finMatrix[i,j] + Create1Matrix[i,w]*Create2Matrix[w,j]; 
    return finMatrix;
}

Console.Clear();
Console.WriteLine("Введите количество строк 1-й матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1-й матрицы: ");
int collumns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк 1-й матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1-й матрицы: ");
int collumns2 = Convert.ToInt32(Console.ReadLine());

if (collumns1!=rows2)
Console.WriteLine("Невозможно произвести операцию");

Console.WriteLine();
int [,] firstTaskArray = Create1Matrix(rows1,collumns1);
ShowArray(firstTaskArray);
int [,] secondTaskArray = Create2Matrix(rows2,collumns2);
ShowArray(secondTaskArray);
int [,] resultMatrix = MatrixCom(firstTaskArray,secondTaskArray);
ShowArray(resultMatrix);
