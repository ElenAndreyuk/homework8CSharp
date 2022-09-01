// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] arraySnail = new int[n, n];
int number = 1; //число для занесения в массив
int count = n - 1; //счетчик повторений

void FillArrayToRigth(int[,] matrix, int i, int j)
{
    for (j = 0; j <= count; j++)// to right
    {
        if (number <= n * n)
        {
            matrix[i, j] = number;
            number++;
        }
        else
        {
            return;
        }

    }
}    

void FillArrayToDown (int[,] matrix, int i, int j) 
{
    for (; i <= count; i++) // to down
    {
        if (number <= n * n)
        {
            matrix[i, j] = number;
            number++;
        }
        else
        {
            return;
        }
    }
}
void FillArrayToLeft (int[,] matrix, int i, int j) 
{   
    for (; i > 0; i--)// to left
    {
        if (number <= n * n)
        {
            matrix[i, j] = number;
            number++;
        }
        else
        {
            return;
        }
    }
}
void FillArrayToUp (int[,] matrix, int i, int j)  
{  
    for (; j > 0; j--)//to up
    {
        if (number <= n * n)
        {
            matrix[i, j] = number;
            number++;
            System.Console.Write($"{matrix[i, j]}  ");
        }
        else
        {
            return;
        }
    }
}

void FillArraySnail (int [,] matrix)
{
    FillArrayToRigth( [,] matrix, int i, int j);

}
count = count - 2;

i = 0;
j = 0;
System.Console.WriteLine();
System.Console.WriteLine("snail");
System.Console.WriteLine();


for (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        System.Console.Write($"{matrix[i, j]}  ");
    }
    System.Console.WriteLine();
}

