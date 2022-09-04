// // Задача 57 Составить частотный словарь 
//элементов двумерного массива. Частотный словарь 
//содержит информацию о том, сколько раз 
//встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
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
void SortBubble(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            for (int a = 0; a < matr.GetLength(0); a++)
            {
                for (int b = 0; b < matr.GetLength(1); b++)
                {
                    if (matr[a, b] > matr[i, j])
                    {
                        int temp = matr[i, j];
                        matr[i, j] = matr[a, b];
                        matr[a, b] = temp;
                    }
                }
            }
        }
    }
}


Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
Print(array);
System.Console.WriteLine();
SortBubble(array);

int number = array[0, 0];
int counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == number)
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"Число {number} встречается {counter} раз");
            counter = 1;
            number = array[i, j];
        }
    }
}

