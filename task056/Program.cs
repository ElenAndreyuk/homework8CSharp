// //Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 5);
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
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Print(array);
System.Console.WriteLine();
int[] SumString(int[,] matr)
{
    int[] sums = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sums[i] = sums[i] + matr[i, j];
        }
    }
    return sums;
}

int[] sums = SumString(array);
int stringMin = sums[0];
int result = 0;
for (int i = 0; i < sums.Length; i++)
{
    if (sums[i] < stringMin)
    {
        stringMin = sums[i];
        result = i;
    }

}
System.Console.WriteLine($"Строка с наименьшей суммой: {result}");




