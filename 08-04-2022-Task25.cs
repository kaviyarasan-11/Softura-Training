using System;
using System.Collections.Generic;
using System.Text;

namespace Day25
{
    class _08_04_2022_Task25
    {
        public  static int CGoat(int eyes,int legs)
        {
            int count = 0;
            count = (legs)-(eyes-1) ;
            count = count /2 ;
            return count;
        }
        public static void Main()
        {
            int eyes = 52, legs = 80;
            int Goat = CGoat(eyes,legs);
            Console.WriteLine("No of Goat:"+" "+Goat);
            Console.WriteLine("No of Duck:" + " " + (Goat-2));
        }
    }
}
