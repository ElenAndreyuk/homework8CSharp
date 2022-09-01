// Задача 61 Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// ........1
// ......1 1
// ....1 2 1
// ..1 3 3 1
// .1 4 6 4 1

// Точки в началах строк в примере решения проставлены, так как редактор
// игнорирует пробелы в начале строки и выравнивает строки по левому краю.
// Треугольник становится не равнобедренным, а прямоугольным.
// В своем варианте решения попробуйте вывести равнобедренный треугольник без дополнительных точек.
Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
const int cellWidth = 2;

int[,] triangle = new int[n, n];

void FillTriangle()
{
    for (int i = 0; i < n; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}
void PrintTriangle()
{
    int col = cellWidth * n;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0)
            {
                Console.Write($"{triangle[i, j],cellWidth}");
                col += cellWidth * 2;
            }

        }
        col = cellWidth * n - cellWidth * (i + 1);
        System.Console.WriteLine();
    }
}
FillTriangle();
System.Console.WriteLine();
PrintTriangle();
