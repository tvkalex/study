// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 11
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;
int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArr;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}