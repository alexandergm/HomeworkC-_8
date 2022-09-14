Console.Write("Введите количество строк 1 матрицы: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк матрицы: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы: ");
int d = int.Parse(Console.ReadLine()!);
int[,] matrix1 = new int[a,b];
int[,] matrix2 = new int[c,d];
Console.WriteLine("Первая матрица:");
PrintMatrix(FillMatrix(matrix1));
Console.WriteLine("Вторая матрица:");
PrintMatrix(FillMatrix(matrix2));
Console.WriteLine("Результат перемножения матриц:");
PrintMatrix(Multiply());

int[,] FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "\t" );
        }
        Console.WriteLine();
    }
}

int[,] Multiply()
{
    if (matrix1.GetLength(0) != matrix2.GetLength(1)) throw new Exception("Матрицы нельзя перемножить");
    int[,] temp = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                temp[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return temp;
}