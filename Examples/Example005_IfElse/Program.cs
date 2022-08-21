Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();
if(username.ToLower() == "ivan")
{Console.Write("Ура, это же Иван!!!");}
else{Console.Write("Привет, ");
Console.Write(username);}