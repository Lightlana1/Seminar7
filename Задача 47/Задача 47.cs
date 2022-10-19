// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Task47() // двумерные массивы 
{ 
    int rows = 3; // строки 
    int columns = 4; // колонки 
        
    double[,] numbers = new double[rows, columns];

    FillArray(numbers);

    PrintArray (numbers);
}

void FillArray(double[,] numbers)
{
    Random random = new Random(); 
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки 

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.NextDouble(); 
        }  
    }
}

void PrintArray (double[,] numbers)
{
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(numbers[i, j], 1);
            Console.Write(numbers[i, j] + "\t"); 
        } 
        Console.WriteLine(); 
    }
}

Task47();