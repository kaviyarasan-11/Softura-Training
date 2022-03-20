using System;
class userlogin
{
public void login(String num1,String num2)
{ 
  Console.WriteLine("EmailID");
  Console.WriteLine("Password");
}
public void login(String num3,int num4)
{
  Console.WriteLine("Membership ID");
  Console.WriteLine("Pin");
}
public void login(long num5,int num6)
{
  Console.WriteLine("Mobile number");
  Console.WriteLine("Pin");
}
public static void Main()
{
 userlogin obj=new userlogin();
 Console.WriteLine("EmailId & Passwaord:");
 obj.login(Console.ReadLine(),Console.ReadLine());
Console.WriteLine("Membership ID & Pin:");
 obj.login((Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Mobile number & Pin:");
 obj.login(Convert.ToInt64(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
}

}