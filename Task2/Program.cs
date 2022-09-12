//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет


Console.WriteLine("Введите число строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[m,n];
Console.WriteLine("Введите номер строки элемента:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента:");
int y = Convert.ToInt32(Console.ReadLine());
FillArray(newarray);
PrintArray(newarray);
if(x > m || y > n)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else
{
    Console.WriteLine($"Число на позиции строки {x} и столбца {y}: {newarray[x,y]}");
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
