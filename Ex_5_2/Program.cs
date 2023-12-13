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
int[,] massiv2d = new int[5, 6];
int temp;
GenerateMatrix(massiv2d);
PrintMatrix(massiv2d);
for (int j = 0; j < massiv2d.GetLength(1); j++)
{
    temp = massiv2d[massiv2d.GetLength(0) - 1, j];
    massiv2d[massiv2d.GetLength(0) - 1, j] = massiv2d[0, j];
    massiv2d[0, j] = temp;
}
Console.WriteLine();
PrintMatrix(massiv2d);
