// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int count = 24;
int[,,] figure = Create3DArray(2, 2, 2);

for (int i = 0; i < figure.GetLength(0); i++)
{
    for (int j = 0; j < figure.GetLength(1); j++)
    {
        for (int k = 0; k < figure.GetLength(2); k++)
        {
            Console.Write($"{figure[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] number = new int[count];
    int num = 10;
    for (int i = 0; i < number.Length; i++)
        number[i] = num++;
    for (int i = 0; i < number.Length; i++)
    {
        int index = new Random().Next(0, number.Length);
        int temp = number[i];
        number[i] = number[index];
        number[index] = temp;
    }
    int numberIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number[numberIndex++];
            }
        }
    }
    return array;
}
