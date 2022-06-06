//Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }
    }
}
void PrintArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j]} ");

        }
        Console.WriteLine();
    }
}


Console.WriteLine("Выведем на экран двумерный массив заполненный по следующим правилом: Aₘₙ = m+n");
Console.WriteLine("Bведите количество строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Получившийся массив: ");
PrintArray(matrix);


