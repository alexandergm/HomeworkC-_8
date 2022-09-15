Console.Write("Введите количество строк массива: ");
int arraySizeX = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int arraySizeY = int.Parse(Console.ReadLine()!);
int[,] array = new int[arraySizeX, arraySizeY];

FillArrayInSpiral(array);
PrintArray(array);

void FillArrayInSpiral(int[,] array)
{
    int posI = 0;
    int posJ = 0;
    bool isItNewCircle = true;

    for (int i = 0; i < array.Length; i++)
    {
        array[posI, posJ] = i + 1;

        if (posJ + 1 < array.GetLength(1) && isItNewCircle && array[posI, posJ + 1] == 0)
        {
            posJ++;
            continue;
        }
        else
        {
            isItNewCircle = false;
        }
        
        if (posI + 1 < array.GetLength(0) && array[posI + 1, posJ] == 0)
        {
            posI++;
            continue;
        }
        
        if (posJ - 1 >= 0 && array[posI, posJ - 1] == 0)
        {
            posJ--;
            continue;
        }
        
        if (posI - 1 >= 0 && array[posI-1, posJ] == 0)
        {
            posI--;
            continue;
        }
        else
        {
            posJ++;
            isItNewCircle = true;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}