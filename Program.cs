// Задача 47
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));


Console.Write("Введите количество строк массива: ");
int rows = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));

Console.Write("Введите количество столбцов массива: ");
int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));

double[,] array = GetArray(rows, columns, -9, 9);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    Random rng = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(minValue + (maxValue - minValue) * rng.NextDouble(),2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) ; j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    
}