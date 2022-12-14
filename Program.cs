void Task47() 
{
    // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] numbers = new double[rows, columns];
    Console.WriteLine($"Размер массива: {rows} x {columns}");
    FillArreyDouble(numbers, -99, 99, 1);
    ShowArreyDouble(numbers);
}
void Task50() 
{
    // Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] numbers = new double[rows, columns];
    Console.WriteLine($"Размер массива: {rows} x {columns}");
    FillArreyDouble(numbers, -99, 99);
    ShowArreyDouble(numbers);
    Console.WriteLine("-----------------------");

    Console.Write("Введите индекс строки: ");
    int indexRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int indexColumn = Convert.ToInt32(Console.ReadLine());

    if (indexRow >= rows || indexColumn >= columns || indexRow < 0 || indexColumn < 0)
    {
        Console.WriteLine("Элемента с таким индексом не существует.");
    }
    else
    {
        Console.WriteLine($"Элемент с индексом {indexRow} x {indexColumn} равен: {numbers[indexRow, indexColumn]}");  
    }
}
void Task52() 
{
    // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Размер массива: {rows} x {columns}");
    FillArreyInt(numbers, 0, 99);
    ShowArreyInt(numbers);

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {j + 1}-ого столбца равно: {Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(rows), 2)}"); 
    }
}
void ShowArreyDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArreyDouble(double[,] arr, double min = 0, double max = 0, int round = 0)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble() * (max - min) + min, round);
        }
    }
}
void ShowArreyInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArreyInt(int[,] arr, int min = 0, int max = 0)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
}

//Task47();
//Task50();
Task52();