/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
Console.WriteLine("Необходимо задайть прямоугольный двумерный массив");
Console.WriteLine();
Console.WriteLine("Введите размерность массива m x n");
Console.WriteLine();

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
int SummLineInMatrix(int[,] matrix, int i)
{
    int summLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        summLine = summLine + matrix[i, j];
    }
    return summLine;
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
int m = GetNumber("Введите количество строк в массиве m:");
int n = GetNumber("Введите количество столбцов в массиве n:");
Console.WriteLine();
int[,] result = new int[m, n];
InitMatrix(result);
PrintMatrix(result);
int minSummLine = 0;
int summLine = SummLineInMatrix(result, 0);
for (int i = 1; i < result.GetLength(0); i++)
{
    int tempSummLine = SummLineInMatrix(result, i);
    if(summLine > tempSummLine)
    {
        summLine = tempSummLine;
        minSummLine = i;
    }
}
Console.WriteLine($"Строка {minSummLine} с наименьшей суммой элементов = {summLine} в строке");