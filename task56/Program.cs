/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[num, num];//создали массив
Console.WriteLine($"Наименьшая сумма элементов в строке под индексом: {FillArray(array)}");

int FillArray(int[,] array)//метод для заполнения массива, нахождения суммы
// построчно и поиска наименьшей суммы
{
    int line = 0;//это для строки, в которой будет наименьшая сумма
    int min = 1000;
    for (int i = 0; i < num; i++)
    {
        int sum = 0;
        for (int j = 0; j < num; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            sum = sum + array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.Write($" (сумма - {sum})");
        if (sum < min)
        {
            line = i;// запоминаем строку с наимельшей суммой
            min = sum;
        }
        Console.WriteLine();
    }
    return line;
}
