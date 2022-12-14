using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._00
{
    internal class Book
    {
        public string title;
        private int pages;
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }
    }
}
