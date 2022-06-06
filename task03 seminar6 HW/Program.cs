//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
}
void PrintArray(int[,] printArray)
{
    for (int m = 0; m < printArray.GetLength(0); m++)
    {
        for (int n = 0; n < printArray.GetLength(1); n++)
        {
           Console.Write($"{printArray[m,n]} ");
    
        }
        Console.WriteLine();
    }
}
void GhangeArray (int[,] changeArr )
{
    for (int p = 0; p < changeArr.GetLength(0); p++)
    {
        for (int q = 0; q < changeArr.GetLength(1); q++)
        {
           if (p % 2 == 0 && q % 2 == 0)
            changeArr [p,q] = p * q;
   
        }
      
    }
}

Console.WriteLine("Выведем на экран двумерный массив размером n x k заполненный целыми числами");
Console.WriteLine("Bведите количество строк n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов k: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [n,k];
FillArray(matrix);
Console.WriteLine("Получившийся массив: ");
PrintArray(matrix);
Console.WriteLine("Заменим элементы, у которых оба индекса чётные на их квадраты:");
GhangeArray(matrix); 
PrintArray(matrix);

