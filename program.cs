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
            Console.WriteLine("Enter your First name : ");
            string f = Console.ReadLine();
            check.firstName(f);


            Console.WriteLine("Enter your Last name : ");
            string l = Console.ReadLine();
            check.LastName(l);

            Console.WriteLine("Enter your Email address : ");
            string e = Console.ReadLine();
            check.Email(e);

            Console.WriteLine("Enter your mobile number : ");
            string p = Console.ReadLine();
            check.Mobile(p);

            Console.WriteLine("Enter password (minimum 8 characters is requird) : ");
            string w = Console.ReadLine();
            check.password(w);
        }
    }
}
