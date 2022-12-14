using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;
        public string Title(string title)
        {

            this.title = title;
            return title;
        }
        public int Pages(int intpages)
        {
            this.pages = intpages;
            return pages;
        }
        public String Category(string strcategory)
        {
            this.category = strcategory;
            return category;
        }
        public string ReleaseDate(string intreleaseDate)
        {
            this.releaseDate = intreleaseDate;
            return releaseDate;
        }
        public void vypis()

        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
       
        

        


