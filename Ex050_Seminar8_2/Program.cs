// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

Console.Clear();
const int M = 5;
const int N = 4;
int[,] myArray = FillArray(M, N);
PrintArray(myArray);

// Оптимальный вариант с меньшим задействованием ресурсов
int[] arr = new int[10];
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        arr[myArray[i, j]] += 1;
    }
}

// Вариант с использованием индекса
// for (int i = 0; i < myArray. GetLength (0); i++)
// {
//     for (int j = 0, j < myArray.GetLength(1) ; j++)
//     {
//         int index = myArray[i, j];
//         arr [index] += 1;
//     }
// }

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != 0)
    {
        System.Console.WriteLine($"Элемент {i} встречается {arr[i]} раз");
    }
}

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

// Вариант сильно задействует ресурсы, т.к. при большом массиве
// прогоняет каждый элемент по всей цепочке if == k
// for (int k = 0; k < 10; k++)
// {
//     int count = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if (myArray[i, j] == k)
//             {
//                 count++;
//             }
//          }
//     }
    
//     if (count != 0)
//     {
//         System.Console.WriteLine($"Количество элементов {k} = {count}");
//     }
// }