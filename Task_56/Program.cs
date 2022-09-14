Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];
int minRow = 1;
PrintArray(FillArray(array));
Console.WriteLine("Строка с наименьшей суммой элементов: " + MinRowSum() );

int[,] FillArray(int[,] arr)
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
void PrintArray(int[,] arr)
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
int MinRowSum()
{    
    int[] temp = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sum += array[i, j];
        }
        temp[i] = sum;
        Console.WriteLine("Сумма строк {0} строки = {1}", i + 1 , sum);
    }
    int min = temp[0];
    for(int i = 0; i < temp.Length; i++)
    {
        if(temp[i] < min)
        {
            min = temp[i];
            minRow = i + 1;
        }
    }
    return minRow;
}
