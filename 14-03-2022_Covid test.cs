using System;
class covidtest
{
public static void Main()
{
string check;
Console.WriteLine("Do you have travel history");
check = Console.ReadLine();

if( check == "yes")
{
Console.WriteLine("Do you have temperture");
check = Console.ReadLine();
	if(check == "yes")
	{
	Console.WriteLine("Do you have cough/sneez");
	check = Console.ReadLine();
		if(check == "yes")
		{
		Console.WriteLine("swab test");
		check = Console.ReadLine();
		}
		else
		{
		Console.WriteLine("Quaratine, Fever medicine");
		check = Console.ReadLine();
		}
}
	else
	{
	Console.WriteLine("Home Quaratine For 28 days");
	check = Console.ReadLine();
	}
}
else
{
Console.WriteLine("Safe Not COVID-19");
check = Console.ReadLine();
}
}
}