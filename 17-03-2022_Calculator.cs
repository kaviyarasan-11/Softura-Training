using System;
public abstract class calc
{
public abstract void Total();
}
class Addition:calc
{
public override void Total()
{
int num1 = 50;
int num2 = 50;
int total;
total = num1+num2;
Console.WriteLine("Add ="+total);
}
}

class Subtraction:calc
{
public override void Total()
{
int num1 = 100;
int num2 = 50;
int total;
total = num1-num2;
Console.WriteLine("Sub ="+total);
}
}

class Multiplication:calc
{
public override void Total()
{
int num1 = 20;
int num2 = 5;
int total;
total=num1*num2;
Console.WriteLine("Mul ="+total);
}
}

class Division:calc
{
public override void Total()
{
int num1 = 40;
int num2 = 4;
int total;
total=num1/num2;
Console.WriteLine("Div ="+total);
}
}

public class arth
{
public static void Main()
{
calc addobj = new Addition();
addobj.Total();
calc subobj = new Subtraction();
subobj.Total();
calc mulobj = new Multiplication();
mulobj.Total();
calc divobj = new Division();
divobj.Total();
}
}





































