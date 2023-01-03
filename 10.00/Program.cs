using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("Lord of the Rings");
            LOTR.Pages(576);
            LOTR.Category("Fantasy");
            LOTR.Author("J.R.R.Tolkien");
            LOTR.ReleaseDate(1954);
            LOTR.vypis();

        }
    }
}
