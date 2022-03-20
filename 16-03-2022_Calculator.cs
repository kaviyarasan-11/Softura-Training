using System;
class operation1
{
 public void AddNo(int num1,int num2)
  {
    int num3 = num1+num2;
    Console.WriteLine(num3);
  }
    public void AddNo1(int num1,int num2)
  {
    int num3 = num1-num2;
    Console.WriteLine(num3);
  }
class operation2:operation1
{
 public void AddNo2(int num1,int num2)
  {
    int num3 = num1*num2;
    Console.WriteLine(num3);
  }
    public void AddNo3(int num1,int num2)
  {
    int num3 = num1/num2;
    Console.WriteLine(num3);
  }
public static void Main()
{
 operation2 obj = new operation2();
 obj.AddNo(24,45);
 obj.AddNo1(42,13);
 obj.AddNo2(55,32);
 obj.AddNo3(54,54);

}
}
}