Console.Write("Введите количество строк массива: ");
int arraySizeX = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int arraySizeY = int.Parse(Console.ReadLine()!);
Console.Write("Введите глубину массива: ");
int arraySizeZ = int.Parse(Console.ReadLine()!);
int[,,] array = new int[arraySizeX, arraySizeY, arraySizeZ];

FillArray(array, 10, 100);
PrintArrayWithIndex(array);

void FillArray(int[,,] array, int minNumber, int maxNumber)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }
            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }
    return false;
}

void PrintArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}