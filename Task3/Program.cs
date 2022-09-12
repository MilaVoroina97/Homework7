//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
try
{
    Console.WriteLine("Введите число строк двумерного массива:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов двумерного массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] newarray = new int[m,n];
    FillArray(newarray);
    PrintArray(newarray);
    ArithmeticMeanInColumns(newarray);
}
catch
{
    Console.WriteLine("Необходимо вводить только целые и положительные числа.");
}

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,100);
        }
    }
}
void PrintArray(int[,] matrix)
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

void ArithmeticMeanInColumns(int[,] matrix)
{
    
    for(int j = 0; j < matrix.GetLength(1); j++)
    {   
        double average = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            average = (average + matrix[i,j]);
        }
        average = (average / matrix.GetLength(0));
        Console.WriteLine($"Среднее арифметическое {j+1} столбца : {average}");
    }

}


