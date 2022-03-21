using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace ConsoleApp5
{
    class Employee
    {
        public static void Main()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1,"Name:Rukesh,ID:1234,Gender:Male,Age:21");
            dic.Add(2, "Name:Nithin,ID:1235,Gender:Male,Age:21");
            dic.Add(3, "Name:Kavi,ID:1236,Gender:Male,Age:21");
            FileStream fs = new FileStream("D:\\Softura tasks\\softura Task10\\21-03-2022_Employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (var v in dic)
                Console.WriteLine("Employee Id: {0}  {1}", v.Key, v.Value);
            foreach (var v in dic)
            {
                bw.Write(v.Key + v.Value);
                bw.Write("\n");
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}
