using static System.Console;
Clear();
//Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
//и возвращающий значение этого элемента или же указание, что такого элемента нет.

Write("Введите позицию элемента: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray();
PrintMatrixArray(array);
ElementValue(array, (int.Parse(parameters[0])), (int.Parse(parameters[1])));



int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int[,] resultArray = new int[rnd.Next(1, 10), rnd.Next(1, 10)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(-99, 100);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Write($"{arr1[i, j]} ");
        }
        WriteLine();
    }
}

void ElementValue(int[,] arr, int rows, int colums)
{
    if(rows <= arr.GetLength(0) && colums <= arr.GetLength(1)) 
    WriteLine($"Значение элемена массива с позицией [{rows},  {colums}]: \n{arr[rows, colums]}");
    else WriteLine($"Элемента с позицией [{rows},  {colums}] в данном массиве нет.");
}