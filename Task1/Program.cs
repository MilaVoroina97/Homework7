//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите число строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] newarray = new double[m,n];
void FillDoubleArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
}
void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
FillDoubleArray(newarray);
PrintArray(newarray);
