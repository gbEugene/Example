Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алина")
{
    Console.WriteLine("Привет моя умничка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}