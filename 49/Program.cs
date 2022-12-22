// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите число m");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n= Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= i+j;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
