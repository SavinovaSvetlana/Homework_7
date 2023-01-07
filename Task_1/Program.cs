// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int[,] CreateArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    return matrix;
}
CreateArray(3, 4);