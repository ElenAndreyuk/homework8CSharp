// Напишите программу, которая заполнит спирально массив 4 на 4.
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

int n = 4;
int[,] arraySnail = new int[n, n];
int number = 1; //число для занесения в массив

int i = 0;
int j = 0;

while (number <= (arraySnail.GetLength(0) * arraySnail.GetLength(1)))
{
    arraySnail[i, j] = number;
    number++;
    if (i <= j + 1 && i + j < arraySnail.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= arraySnail.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > arraySnail.GetLength(1) - 1)
        j--;
    else
        i--;
}
Print(arraySnail);
