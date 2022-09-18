// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите размер матриц: ");
bool m = int.TryParse(Console.ReadLine(), out int size);

if (m != true)
{
    Console.WriteLine("Число введено неверно.");
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
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

int[,] arrayA = new int[size, size];
int[,] arrayB = new int[size, size];
CreateArray(arrayA);
CreateArray(arrayB);
int[,] arrayC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            arrayC[i, j] = arrayC[i, j] + (arrayA[i, k] * arrayB[k, j]);
        }
    }
}
Console.WriteLine("Матрица А");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица В");
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
PrintArray(arrayC);