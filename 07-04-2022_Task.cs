using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lynq
{
    class Task24
    {


        public static void Main()
        {
            IList<BookStore> StrData = new List<BookStore>()
                {
                  new BookStore() { BookID = 1, Title = "It's a Wonderful Life", Author ="Ruskin Bond", Price =650 },
                 new BookStore() { BookID = 2, Title = "The Pregnancy Bible", Author ="Kareena Kapoor", Price =300 },
                 new BookStore() { BookID = 3, Title = "The India Story", Author = "Bimal Jalan", Price =500 },
                 new BookStore() { BookID = 4, Title = "The Great Big Lion", Author = "Chryseis Knight", Price =700 },
                 new BookStore() { BookID = 5, Title = "In an ideal world", Author ="Bamal", Price =250},
                };
            
            var myQry = from str in StrData
                        select str;
            foreach (var s in myQry)
                Console.WriteLine("{0} {1} {2} {3}", s.BookID, s.Title, s.Author, s.Price);

            Console.WriteLine("*********");

            
            var stuqry = StrData.OrderBy(s => s.Author);
            foreach (var s in stuqry)
                Console.WriteLine(s.Author);

            Console.WriteLine("*********");

            
            var stuqry2 = StrData.OrderBy(s => s.Price);
            foreach (var s in stuqry2)
                Console.WriteLine(s.Price);

            Console.WriteLine("*********");

            
            string A = Console.ReadLine();
            var stuqry3 = from str in StrData
                          select str;
            foreach (var s in stuqry)
                if (A == s.Author)
                {
                    Console.WriteLine(s.Title);
                }


        }
    }
    class BookStore
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
