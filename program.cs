using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Last_Name_UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your First name : ");
            string f = Console.ReadLine();
            check.firstName(f);


            Console.Write("Enter your Last name : ");
            string l = Console.ReadLine();
            check.LastName(l);

            Console.Write("Enter your Email address :");
            string e = Console.ReadLine();
            check.Email(e);
        }
    }
}
