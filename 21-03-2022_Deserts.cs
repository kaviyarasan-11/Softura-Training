using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace ConsoleApp5
{
    class Deserts
    {
        public static void Main()
        {
           
            Queue Desserts = new Queue();
            Desserts.Enqueue("1.Gajar ka halwa");
            Desserts.Enqueue("2.Kaju katli");
            Desserts.Enqueue("3.Motichoor laddu");
            Desserts.Enqueue("4.Rasgulla");
            Desserts.Enqueue("5.Sohan halwa");
            Desserts.Enqueue("6.Rabri");
            Desserts.Enqueue("7.Kuzhi paniyaram");
            Console.WriteLine("List of Desserts :"+ Desserts.Count);
            /*while(Desserts.Count>0)
            {
                Console.WriteLine( Desserts.Dequeue());
            }*/  
            
            FileStream fs = new FileStream("D:\\Softura tasks\\softura Task10\\21-03-2022_Collections of Desserts.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter  bw = new BinaryWriter(fs);
            Console.WriteLine("List of Desserts :" + Desserts.Count);
            Console.WriteLine("Desserts of Restaurant :" );
            foreach (string coll in Desserts)
            {
                bw.Write("\n"+coll);
            }
            bw.Flush();
            bw.Close();
            fs.Close();

            FileStream fs1 = new FileStream("D:\\Softura tasks\\softura Task10\\21-03-2022_Collections of Desserts.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            string str = br.ReadString();
            br.Close();
            fs1.Close();

            FileInfo fi = new FileInfo(@"D:\\Softura tasks\\softura Task10\\21-03-2022_Collections of Desserts.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.ReadLine();

        }
    }
}
