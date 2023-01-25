using static System.Console;
Clear();

//Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.


int[,] matrixArray = GetMatrixArray();
double[] array = ArrayArithmeticMeanColums(matrixArray);
WriteLine("Создали двумерный массив с рандомным размером и значением элементов:");
WriteLine();

PrintMatrixArray(matrixArray);
WriteLine("------------------------------------------------------------------------------------------------------------");

WriteLine($@"Создали массив со значениями элементов соответствующие среднему арифметическому столбцов двумерного массива :

[{String.Join("   ", array)}]");

WriteLine();


int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int[,] resultArray = new int[rnd.Next(3, 5), rnd.Next(3, 10)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j],3}  ");
        }
        WriteLine();
    }
}

double[] ArrayArithmeticMeanColums(int[,] arr1)
{
    double[] resArray = new double[arr1.GetLength(1)];

    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            sum += arr1[i, j];
            resArray[j] = Math.Round((sum / arr1.GetLength(0)), 2);
        }

    }
    return resArray;
}
