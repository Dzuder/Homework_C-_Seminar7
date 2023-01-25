using static System.Console;
Clear();
// Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.


WriteLine("Введите размер двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);




double[,] GetMatrixArray(int rows, int colums)
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, colums];
    for (int i = 0; i < rows; i++ )
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = Math.Round(rnd.NextDouble()*((100)-(-99))+(-99),1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j], 7} ");
        }
        WriteLine();
    }
}