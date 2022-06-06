// Показать двумерный массив размером m×n заполненный вещественными числами


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
        }
    }
}
void PrintArray(int[,] printArray)
{
    for (int m = 0; m < printArray.GetLength(0); m++)
    {
        for (int n = 0; n < printArray.GetLength(1); n++)
        {
            Console.Write($"{printArray[m, n]} ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Выведем на экран двумерный массив размером m x n заполненный целыми числами");
Console.WriteLine("Bведите количество строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Получившийся массив: ");
PrintArray(matrix);

