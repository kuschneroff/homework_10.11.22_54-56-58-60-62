/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();
Console.WriteLine("Необходимо задать ДВЕ матрицы");

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5:f0} |");
        }
        Console.WriteLine();
    }
}
void ProductMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int product = 0;
            for (int g = 0; g < matrixFirst.GetLength(1); g++)
            {
                product = product + (matrixFirst[i,g] * matrixSecond[g,j]);
            }
            resultMatrix[i,j] = product;
        }
    }
}

int m = GetNumber("Введите количество строк в Первой матрице m: ");
int n = GetNumber("Введите количество столбцов в Первой матрице = количеству строк во Втрой n: ");
Console.WriteLine();
int t = GetNumber("Введите количество столбцов во Второй матрице t: ");
int[,] firstMatrix = new int[m,n];
Console.WriteLine($"\nПервая матрица");
InitMatrix(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = new int[n,t];
Console.WriteLine($"\nВторая матрица");
InitMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultProductMatrix = new int[m,t];
ProductMatrix(firstMatrix, secondMatrix, resultProductMatrix);
Console.WriteLine("Произведение Перовой и Второй Матриц");
PrintMatrix(resultProductMatrix);
Console.WriteLine();