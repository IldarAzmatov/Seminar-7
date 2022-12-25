// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = rnd.Next(2, 10);
        Console.Write($"{nums[i, j]}, ");
    }
    Console.WriteLine();
}

int summ = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
            summ += nums[i, j];
    }
}
Console.WriteLine($"Сумма членов, находящихся на диагонали {summ}");