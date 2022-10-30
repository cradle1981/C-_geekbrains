Console.Write("Введите имя пользоваателя: ");
string username = Console.ReadLine();

if(username.ToLower() == "dmitrii")
{
    Console.WriteLine("Wow, it's Dmitrii!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}