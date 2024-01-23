using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Classes_and_Objects_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //create a new bookobject, at this point Book is now a data type in C#

            //Creation of first book, you can now create thousands of different book eg for a library app
            book1.title = " Harry Potter ";
            book1.author = "JK Rowline";
            book1.pages = 400;

             Book book2 = new book();
            book2.tittle = "Lord of the rings";
            book2.author = "Tolkein";
            book2 pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            //freeze
            Console.ReadLine();



                    

        }
    }
}
