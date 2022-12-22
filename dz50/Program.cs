// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите резмер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int s = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



FillArray(array);

int count = 0;
for (int e = 0; e < array.GetLength(0); e++)
{
    for (int r = 0; r < array.GetLength(1); r++)
    {
        if (array[e, r] == s)
        {
            Console.WriteLine($"Искомое число находиться в координате {e} и {r}");
            count++;
        }
        
    }
    Console.WriteLine();
}


if (count <= 0) Console.WriteLine($"Такого числа в массиве нет!");