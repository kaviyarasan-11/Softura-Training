using System;
class Electricity
{
public static void Main()
{
int unit; int Rates;

Console.WriteLine("Enter your units");
unit = Convert.ToInt32(Console.ReadLine());

if(units>0 && units<200)
{
Rates1 = 2;
Rates1 = Convert.ToInt32(Console.ReadLine());
}
else if(units>201 && units<350)
{
Rates2 = 3;
Rates2 = Convert.ToInt32(Console.ReadLine());
}
else if(units>351 && units>500)
{
Rates3 = 5;
Rates3 = Convert.ToInt32(Console.ReadLine());
}
else(units<501)
{
Rates4 = 7;
Rates4 = Convert.ToInt32(Console.ReadLine());
}
}
}