using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_10._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            //lotr.category = "roman";
            //lotr.title = "lord of the rings";
            //lotr.releasedate = 1989;
            //lotr.author = "michalelo";
            //lotr.pages = 1000;
            Book LOTR3 = new Book(1000, "lord of the rings3");
            Book LOTR2 = new Book();
            Book Hobbit = new Book(Book.categoryList[4], "Hobbit",500,1724,"samko");
            Console.WriteLine(LOTR.ToString());

        }
    }
}
