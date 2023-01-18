using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_11._00
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


            Librarry schoollibrarry = new Librarry();
            Book geo = new Book("ucebnica", "Geografia", 96, 2002, "Taktik");
            Book bio = new Book("ucebnica", "Biologia", 136, 2019, "preskoly");
            Book mat = new Book("ucebnica", "matematika", 128, 2008, "Gorila");
            Book sjl = new Book("ucebnica", "slovenèina", 125, 1999, "Martinus");
            schoollibrarry.StudentsList.Add("John");
            schoollibrarry.StudentsList.Add("Poul");
            schoollibrarry.BooksList.Add(geo);
            schoollibrarry.BooksList.Add(sjl);
            schoollibrarry.BooksList.Add(bio);
            schoollibrarry.BooksList.Add(mat);
            schoollibrarry.NumberOfBooks = 4;
            schoollibrarry.NumberOfStudents = 2;
            Console.WriteLine(schoollibrarry.ToString());

        }
    }
}
