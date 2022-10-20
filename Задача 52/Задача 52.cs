//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Task52() // двумерные массивы 
{ 
    Random random = new Random(); 
    int rows = random.Next(4, 5); // строки 
    int columns = random.Next(4, 5); // колонки 
        
    int[,] numbers = new int[rows, columns]; 

    FillArray(numbers);

    PrintArray (numbers);

    for (int j = 0; j < columns; j++)  
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers[i, j];
        }  
        Console.WriteLine();
        Console.Write($"Среднее арифметическое столбца с индексом {j} = { sum/numbers.GetLength(0)}");
    }

}

void FillArray(int[,] numbers)
{
    Random random = new Random(); 
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки 

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 11); 
        }  
    }
}

void PrintArray (int[,] numbers)
{
    int rows =  numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t"); 
        } 
        Console.WriteLine(); 
    }
}

Task52();