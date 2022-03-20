using System;
interface Membership
{
void Sliver();
void Gold();
void Platinum();
}
class package:Membership
{
public void Sliver()
{
Console.WriteLine("Sliver Resort: 3 days accomodation at resort");
Console.WriteLine("Sliver Food:No dinner provide for sliver membership");
}
public void Gold()
{
Console.WriteLine("Gold Resort : 5 Days accomodation at resort");
Console.WriteLine("Gold Food:2 days dinner at house for gold membership");
}
public void Platinum()
{
Console.WriteLine("Platinum Resort: 7 days accomodation at resort");
Console.WriteLine("Paltinum Food:5 days dinner at house for platinum membership");
}
}
class member
{
public static void Main()
{
package obj = new package();
obj.Sliver();
obj.Gold();
obj.Platinum();
}
}