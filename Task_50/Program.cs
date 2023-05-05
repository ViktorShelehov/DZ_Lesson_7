//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
//------------------ Высокоуровневый код ----------------------------
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine() ?? "");
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
    if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
        {
            int value = array[row, col];
            Console.WriteLine($"Значение элемента на позиции ({row}, {col}): {value}");
        }
        else
        {
            Console.WriteLine("Ошибка: такого элемента не существует.");
        }

        Console.ReadKey();
}
//-------------------- Конец -----------------------------------------