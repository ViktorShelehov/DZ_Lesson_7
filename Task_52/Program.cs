//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
//------------------ Высокоуровневый код ----------------------------
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int m = array.GetLength(0);
int n = array.GetLength(1);
PrintArray2(args);

//---------------------- Реализация ----------------------------------
//--------------------------------------------------------------------
//---------------- Метод решения задачи ------------------------------
//--------------------------------------------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
//---------------------------------------------------------------------
//--------------- Метод вывода данных ---------------------------------
//---------------------------------------------------------------------
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
//---------------------------------------------------------------------
void PrintArray2(string[] args)
{
    for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
            double average = (double)sum / m;
            Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {average}");
        }

        Console.ReadKey();
}
//------------------ Конец --------------------------------------------