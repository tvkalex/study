Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!; //Add ! as null forgiving to avoid mistake
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}