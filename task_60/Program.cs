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
    int tempSize = rows*collumns*layers; 
    if (tempSize <=90)
    {
    int [] tempAr = UnVal(tempSize);
    int iTemp = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            for (int z = 0; z < layers; z++)
            {
                if (iTemp >=0 && iTemp < tempSize)
                {
                    Create3dArray[i,j,z] = tempAr[iTemp];}
                    iTemp++;
                }
            }
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

int [] UnVal (int size)
{
    int [] unAr = new int [size];
    for (int i = 0; i < size; i++)
        {
            unAr[i] = new Random().Next(10,100);
            if (i != 0)
            {
                for (int r = 0; r < i; r++)
                {
                    while (unAr [r] == unAr[i])
                    {
                        unAr [r] = new Random().Next(10,100);
                    }
                }
            
            }   
        } 
    return unAr;
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