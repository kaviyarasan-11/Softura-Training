using System;
class table
{
public static void Main()
{
Console.WriteLine("Enter the table:");
int table = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
	Console.WriteLine(table + "*" + i + "=" +table*i );
}
}
}