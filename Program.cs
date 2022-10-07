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
}
void Task52() 
{
    // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
Task47();
//Task50();
//Task52();