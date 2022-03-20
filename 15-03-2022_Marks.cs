using System;
class Marks
{
public static void Main()
{
Console.WriteLine("Enter the student name:");
string name = Console.ReadLine();
int [] marks=new int[5];
Console.WriteLine("Enter the Marks:");
for(int i=0;i<5;i++)
{
	marks[i]=Convert.ToInt32(Console.ReadLine());
}
int sum=0;
for(int i=0;i<5;i++)
{
	sum=marks[i]+sum;
}
int percentage;
percentage = sum/5;
Console.WriteLine("Total mark of student:"+sum);
Console.WriteLine("Percentage is:"+percentage);
}
}