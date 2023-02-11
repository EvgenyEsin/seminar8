/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void FillArray(int[,] array)// метод для создания матрицы А и В
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)// метод для вывода матрицы в консоль
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

// метод для умножения матриц:
// А(0,0)*В(0,0) + А(0,1)*В(1,0) = М(0,0)
// А(0,0)*В(0,1) + А(0,1)*В(1,1) = М(0,1)
// А(1,0)*В(0,0) + А(1,1)*В(1,0) = М(1,0)
// А(1,0)*В(0,1) + А(1,1)*В(1,1) = М(1,1)
void Multiplication(int[,] array, int line, int colum, int[,] matrixA, int[,] matrixB)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < line; j++)
        {
            array[i, j] = 0;
            for (int k = 0; k < colum; k++)
            {
                array[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
}


Console.Write("Введите число строк матрицы: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[line, colum];
int[,] matrixB = new int[colum, line];
FillArray(matrixA);
FillArray(matrixB);
int[,] matrixResult = new int[colum, line];
Multiplication(matrixResult, line, colum, matrixA, matrixB);


Console.Write("Матрица А");
Console.WriteLine();
PrintArray(matrixA);
Console.WriteLine("Матрица В");
PrintArray(matrixB);
Console.WriteLine("Результирующая матрица");
PrintArray(matrixResult);