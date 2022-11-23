Console.Write("Введите Имя пользывателя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("супер,это Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
