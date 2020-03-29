using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girrafe
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            shrek.Rating = "R";
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}
