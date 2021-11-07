using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first name");

            string firstname = Console.ReadLine();
            FirstName(firstname);
         

                 Console.WriteLine("Enter a password");
            string w = Console.ReadLine();
            check.password(w);

        }
    }
}
