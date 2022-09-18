// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк: ");
bool n = int.TryParse(Console.ReadLine(), out int sizeArray);
if (n != true)
{
    Console.WriteLine("Число введено неверно.");
}
int[,] numbers = new int[sizeArray, sizeArray + 1];
CreateRandomArray(numbers);
Print2dArray(numbers);

// int numberLine = 1;
MinNumberString(numbers);

int MinNumberString(int[,] array)
{
    int numberLine = 1;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int minsum = 0;
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {

            minsum = minsum + numbers[0, j];
          
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            numberLine++;
            // i++;
        }
        else
        {
             Console.WriteLine($"Строка с наименьшей суммой элементов: {numberLine}");
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {numberLine}");
    return numberLine;
    }

// Console.WriteLine($"Строка с наименьшей суммой элементов: {numberLine}");

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}