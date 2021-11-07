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
            /*Console.WriteLine("Enter your First name : ");
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

             /*Console.WriteLine("Enter password (minimum 8 characters is requird) : ");
              string w = Console.ReadLine();
              check.password(w);*/

            /*     Console.WriteLine("Enter Password (first later it should be captical ) : ");
                   string w = Console.ReadLine();
                   check.password(w);
            */

            Console.WriteLine("Enter a password");
            string w = Console.ReadLine();
            check.password(w);

            Console.WriteLine("\n To checking valid and invalid emails!");
            string[] emailEntries = { "abc@gmail.com", "1.abc@yahoo.com", "2.abc-100@yahoo.com", "3.abc.100@yahoo.com", "2.abc111@abc.com", "4.abc-100@abc.net", "5.abc.100@abc.com.au", "6.abc@1.com", "7.abc@gmail.com.com", "8.abc+100@gmail.com" };
            string[] testInvalidEmail = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            check.EmailArr(emailEntries);
            Console.WriteLine();
            check.EmailArr(testInvalidEmail);
        }
    }
}
