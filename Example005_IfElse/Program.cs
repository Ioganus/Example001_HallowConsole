Console.Write("Send you name: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Маша пришла!");
}
else
{
    Console.Write("Hallo, ");
    Console.WriteLine(username);
}