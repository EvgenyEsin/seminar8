/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] array = new int[3, 4];// создаем пустой массив 3 на 4
FillArray(array); // вызываем метод заполнения массива
PrintArray(array); // вызываем метод вывода массива
MoreLess(array); // вызываем метод упорядочения массива
Console.WriteLine("------>");
PrintArray(array); // вызываем метод вывода массива (уже упорядоченного)

void FillArray(int[,] array)//метод для наполнения массива
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)//метод вывода массива в консоль
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MoreLess(int[,] array) // метод для сортировки массива
{
    int temp = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                if (array[i, k] < array[i, (k + 1)])
                // чтобы отсортировать по возростанию
                // надо заменить на знак ">"
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }

            }
        }
    }
}