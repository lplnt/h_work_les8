// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Задайте количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n - 1;
int sum1 = 0;
int min1 = n * 10;
int minI = 0;

Console.WriteLine();
Console.WriteLine("Получился массив:");
int[,] a = new int[n, m];
Random random = new Random();
for (int i = 0; i < n; i++, Console.WriteLine())
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = random.Next(-10, 10);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
       sum1 += a[i, j];      
    }
    Console.WriteLine();
    Console.WriteLine("Сумма " + (i + 1) + " строки равна " + sum1); 

    if (min1 > sum1)
       {
       min1 = sum1;
       minI = i + 1;
       }
    sum1 = 0;   
}

Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой {minI}! Равная {min1}");