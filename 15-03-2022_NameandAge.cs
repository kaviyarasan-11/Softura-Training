using System;
class person
{
public static void Main()
{
Console.WriteLine("Enter the person name:");
string name= Console.ReadLine();
Console.WriteLine("Enter the person age:");
int age=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<=age;i++)
{
	Console.WriteLine(name);

}
}
}