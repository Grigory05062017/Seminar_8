/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int [,,] Create3dArray (int rows, int collumns, int layers)
{
    int [,,] Create3dArray = new int[rows, collumns, layers];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            for (int z = 0; z < layers; z++)
        Create3dArray[i,j,z] = new Random().Next(10,100);
return Create3dArray;
}


void ShowArray (int [,,] showedArray)
{
    for (int i = 0; i < showedArray.GetLength(0); i++)
    {
        for (int j = 0; j < showedArray.GetLength(1); j++)
            {
               for (int z = 0; z < showedArray.GetLength(2); z++) 
                {
                    Console.Write($"{showedArray[i,j,z]} ({i},{j},{z}) ");
                }
            }
    Console.WriteLine();
    }
Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы: ");
int collumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество слоев матрицы: ");
int layers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,,] firstTaskArray = Create3dArray(rows,collumns,layers);
ShowArray(firstTaskArray);