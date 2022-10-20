// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void Task50() // двумерные массивы 
{
    Random random = new Random();
    int rows = random.Next(4, 8); // строки 
    int columns = random.Next(4, 8); // колонки 

    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    Console.Write("Введите значение i: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение j: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int count = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == n && j == m)
            {
                Console.WriteLine();
                Console.Write("Искомый элемент:" + numbers[i, j]);
                count = 1;
            }
        }
    }

    Console.WriteLine();
    
    if (count != 1)
    {
        Console.Write("Такого числа в массиве нет");
    }

}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0); // строки 
    int columns = numbers.GetLength(1); // колонки 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 1100);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0); // строки 
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

Task50();