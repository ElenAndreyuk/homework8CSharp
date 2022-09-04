// Задача 60. ...Сформируйте трёхмерный массив
//из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите количество строк первого измерения массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второго измерения массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк третьего измерения массива");
int p = int.Parse(Console.ReadLine());


int[,,] matr = new int[m, n, p];

void FillArrayNotRepeat(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            Repeat:
                int check = new Random().Next(10, 100) * (new Random().Next(0, 2) * 2 - 1); ;
                int k1, i1, j1;
                for (k1 = 0; k1 < matr.GetLength(2); k1++)
                {
                    for (i1 = 0; i1 < matr.GetLength(0); i1++)
                    {
                        for (j1 = 0; j1 < matr.GetLength(1); j1++)
                        {
                            if (matr[i1, j1, k1] == check)
                            {
                                goto Repeat;
                            }
                            if ((i1 == i) && (j1 == j) && (k1 == k))
                            {
                                matr[i, j, k] = check;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}

void Print(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
FillArrayNotRepeat(matr);
Print(matr);