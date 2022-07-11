Console.Write("Введите имя пользовател, ");
string username = Console.ReadLine();

if(username.ToLower == "маша")
{
    Console.WriteLine("Ура это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}