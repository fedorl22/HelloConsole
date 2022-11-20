Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
Console.WriteLine("Охренительное счастье привалило - Маша");
} 
else 
{
Console.WriteLine("Привет, "); 
Console.WriteLine(username);  
}