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
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));

            Console.ReadLine();
        }
    }
}
