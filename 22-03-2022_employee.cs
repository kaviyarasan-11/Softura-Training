using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace ConsoleApp2
{
    [Serializable]
    class Employee
    {
        public string empid = "1234";
        public string name = "Nithin";
        public int age = 21;
        public string gender = "Male";
        
    }
    class Empl
    {
        public void SerialtoFile()
        {
            Employee obj1 = new Employee();
            FileStream fs = new FileStream("emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj1);
            fs.Close();
        }
        public void DeSerialData()
        {
            FileStream fs = new FileStream("emp.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Employee obj2 = (Employee)bf.Deserialize(fs);
            Console.WriteLine(obj2.empid);
            Console.WriteLine(obj2.name);
            Console.WriteLine(obj2.age);
            Console.WriteLine(obj2.gender);
            
        }

        public static void Main()
        {
            Empl obj = new Empl();
            obj.SerialtoFile();
            obj.DeSerialData();
            Console.ReadLine();

        }
    }
}
   
    

