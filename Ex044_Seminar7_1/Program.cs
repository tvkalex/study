// Аргументы "out"

// Console.Clear();
// int[] newArr = func(2, 3, 8);
// System.Console.WriteLine($"{newArr[0]} - {newArr[1]}");

// int[] func(int a, int b, int c)
// {
//     int[] arr = new int[2];
//     arr[0] = a + b;
//     arr[1] = b + c;
//     return arr;
// }

Console.Clear();
func(out int x, out int y, 2, 3, 8);
System.Console.WriteLine($"{x} - {y}");

void func(out int x, out int y, int a, int b, int c)
{
    x = a + b;
    y = b + c;
}