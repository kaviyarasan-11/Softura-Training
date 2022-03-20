using System;
class salesmarketing
{
public void SAndMsalary(int SMsalary)
{
double Bsalary = SMsalary * 0.2;
Console.WriteLine("Sales and Marketing salary with bonus:");
Console.WriteLine(SMsalary + Bsalary);
}
}

class production : salesmarketing
{
public void Psalary(int Psalary)
{
double Bsalary = Psalary * 0.1;
Console.WriteLine("Production bonus salary with bonus:");
Console.WriteLine(Psalary + Bsalary);
}
}

class program
{
public static void Main()
{
Console.Write("EmployeeID:");
int ID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ID);

Console.Write("Employee Name:");
string Name = Console.ReadLine();
Console.WriteLine(Name);

Console.Write("Employee Gender:");
string Gender = Console.ReadLine();
Console.WriteLine(Gender);

Console.Write("Employee Years of Experience:");
int YOE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(YOE);

Console.Write("Employee Salary:");
int OSalary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OSalary);

production obj1 = new production();
obj1.SAndMsalary(OSalary);
obj1.Psalary(OSalary);
Console.ReadLine();
}
}
