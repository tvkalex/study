// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.

Console.Clear();
const int M = 5;
const int N = 4;
int[,] myArray = FillArray(M, N);
PrintArray(myArray);

int[,] new_arr = new int[N, M];
for (int i = 0; i < new_arr.GetLength(0); i++)
{
    for (int j = 0; j < new_arr.GetLength(1); j++)
    {
        new_arr[i, j] = myArray[j, i];
    }
}
System.Console.WriteLine();
PrintArray(new_arr);

int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

}