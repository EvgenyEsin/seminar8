/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/* 
        Метод для создания спирального массива.
У меня сначала был очень длинный метод со множеством if и while 
для каждой строки и столбца поочередно, потратил на эту задачу 2 дня
но потом все сократил. Насколько же все было просто! Он может начинаться
с любого числа и быть любого размера.
 */
void FillArray(int[,] spiral, int size, int num)
{
    int count = num;
    int i = 0;
    int j = 0;
    while (count <= size * size + num - 1)
    {
        spiral[i, j] = count;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i >= j && i + j > size - 1) j--;
        else i--;
        count++;
    }
}

// вывод массива в терминал
void PrintArray(int[,] array, int size)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // для выравнивания массива по столбцам
            // все числа должны быть из 2-х символов: -3, 02 и т.д.
            if (array[i, j] > (-1) && array[i, j] < 10) Console.Write("0");
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер спирального массива (для красоты число не должно быть больше 9):");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("С какой цифры начать спиральный массив? (для красоты от -9 до 10) ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] spiral = new int[size, size];
FillArray(spiral, size, num);
PrintArray(spiral, size);