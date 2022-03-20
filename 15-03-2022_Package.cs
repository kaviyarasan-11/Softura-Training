using System;
class pack
{
public static void Main()
{
Console.WriteLine("Enter your package:");
string package = Console.ReadLine();
switch(package)
{
case "packageA":Console.WriteLine("1. South Special");
				Console.WriteLine("2. Children's Club");
				Console.WriteLine("3. Movies");
				Console.WriteLine(" Rates :250");
				break;

case "packageB":Console.WriteLine("1. News");
				Console.WriteLine("2. Sports");
				Console.WriteLine("3. Movies");
				Console.WriteLine("4. Regional-2");
				Console.WriteLine("Rates :450");
				break;

case "packageC":Console.WriteLine("1. Discovery,History,National");
				Console.WriteLine("Rates :350");
				break;
}

}
}