
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(10, 1));

 void Towers(string with = "1", string on = "3", string some = "2", int count = 8)
 {
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();