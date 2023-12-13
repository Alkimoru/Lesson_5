void GenerateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int SumRowElements(int[,] matrix, int i)
{
    int curentSum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        curentSum += matrix[i, j];
    }
    return curentSum;
}
int[,] massiv2d = new int[5, 10];
GenerateMatrix(massiv2d);
PrintMatrix(massiv2d);
int numberMinSumRow = 1;
int curentSum = SumRowElements(massiv2d, 0);
for (int i = 1; i < massiv2d.GetLength(0); i++)
{
    if (curentSum > SumRowElements(massiv2d, i))
    {
        curentSum = SumRowElements(massiv2d, i);
        numberMinSumRow = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {numberMinSumRow}");