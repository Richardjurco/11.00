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
            Book LOTR = new Book("the lord of the Rings", 9250);
            Console.WriteLine(LOTR.title);
            // LOTR.pages is private
        }
    }
}
