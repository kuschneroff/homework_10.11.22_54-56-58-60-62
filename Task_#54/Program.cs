/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("Необходимо задать двумерный массив");
Console.WriteLine("Введите размер массива m x n");
int m = InputNumber("Введите m: ");
int n = InputNumber("Введите n: ");
Console.WriteLine();

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine() ?? "");
    return output;
}

void InitMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void ArrangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(1) - 1; g++)
            {
                if (matrix[i, g] < matrix[i, g + 1])
                {
                    int temp = matrix[i, g + 1];
                    matrix[i, g + 1] = matrix[i, g];
                    matrix[i, g] = temp;
                }
            }
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] result = new int[m,n];
InitMatrix(result);
PrintMatrix(result);
Console.WriteLine("Упорядоченный массив по убыванию элементов каждой строки двумерного массива: ");
ArrangeMatrix(result);
PrintMatrix(result);