// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Задайте количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Получился массив:");

var a = new int[m, n];
var random = new Random();
for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
{
    for (var j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
for (var i = 0; i < a.GetLength(0); i++)
    for (var j = 0; j < a.GetLength(1); j++)
        for (var k = 0; k < a.GetLength(1); k++)
        {
            if (a[i, j] <= a[i, k]) continue;
            var temp = a[i, j];
            a[i, j] = a[i, k];
            a[i, k] = temp;
        }

for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
    for (var j = 0; j < a.GetLength(1); j++)
    {
        Console.Write("{0,4}", a[i, j]);
    }


int
    max = a[0, 0],
    min = a[0, 0],
    maxI = 0,
    maxJ = 0,
    minI = 0,
    minJ = 0;

for (var i = 0; i < a.GetLength(0); i++)
    for (var j = 0; j < a.GetLength(1); j++)
    {
        if (max < a[i, j])
        {
            max = a[i, j];
            maxI = i;
            maxJ = j;
        }
        if (min > a[i, j])
        {
            min = a[i, j];
            minI = i;
            minJ = j;
        }
    }


