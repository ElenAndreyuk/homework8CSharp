// // Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 4);
        }
    }
}
void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк матрицы A");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы A и строк матрицы B");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы B");
int p = int.Parse(Console.ReadLine());
int[,] arrayA = new int[m, n];
int[,] arrayB = new int[n, p];
FillArray(arrayA);
FillArray(arrayB);
Print(arrayA);
System.Console.WriteLine();
Print(arrayB);
System.Console.WriteLine();
int[,] arrayC = new int[m, p];

for (int i = 0; i < arrayC.GetLength(0); i++)
{
    for (int j = 0; j < arrayC.GetLength(1); j++)
    {
        int l = 0;
        int k = 0;
        if (arrayA.GetLength(1) < arrayB.GetLength(0))
        {
            while (k < arrayA.GetLength(1))
            {
                while (l < arrayB.GetLength(0))
                {
                    arrayC[i, j] = arrayC[i, j] + (arrayA[i, k] * arrayB[l, j]);
                    k++;
                    l++;
                }
            }
        }
        else
        {
            while (l < arrayB.GetLength(0))
            {
                while (k < arrayA.GetLength(1))
                {
                    arrayC[i, j] = arrayC[i, j] + (arrayA[i, k] * arrayB[l, j]);
                    k++;
                    l++;
                }
            }
        }
    }
}
Print(arrayC);