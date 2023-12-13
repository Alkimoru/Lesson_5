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
GenerateMatrix(massiv2d);
PrintMatrix(massiv2d);
Console.Write("Введите строку элемента: ");
int massiv2dRow = Convert.ToInt32(Console.ReadLine()); ; //Строка
int massiv2dColumn;
if (massiv2dRow > massiv2d.GetLength(0))
{
    Console.Write("Элемента с такой строкой не существует");
}
else
{
    Console.Write("Введите столбец элемента: ");
    massiv2dColumn = Convert.ToInt32(Console.ReadLine()); ; //Столбец
    if (massiv2dColumn > massiv2d.GetLength(1))
    {
        Console.Write("Элемента с таким столбцом не существует");
    }
    else
    {
        Console.Write(massiv2d[massiv2dRow - 1, massiv2dColumn - 1]);
        // Не слишком понял что именно значит позиция, но если имелся в виду индекс, то последняя строка будет так выглядеть:
        // Console.Write(massiv2d[massiv2dRow, massiv2dColumn]);
    }

}



