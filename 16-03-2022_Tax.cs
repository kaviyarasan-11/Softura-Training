using System;
class VAT{
public void Tax1(float num1)
{
 float vat=(num1/100);
 Console.WriteLine(vat);
}
}
class GST:VAT
{
 public void Tax2(float num1, float num2)
{
   float gst =(num1*num2)/100;
   Console.WriteLine(gst);
}
public static void Main()
{
  GST obj= new GST();
  obj.Tax1(30);
  obj.Tax2(1500,20);
}
}