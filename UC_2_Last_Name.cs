using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Last_Name_UC2
{
    class Last_Name   //create one class.
    {
        public static void LastName(string name)         //declaring the static meythod to take user input.
        {
            string lastname = "^[A-Z]{1}[a-z]{2,}$";        //write regularExpration.   ^=start  $=end.
            Regex a = new Regex(lastname);          //class Ststem.regularExpressions.Regex
                                                    //Regex represent an immutable regular expression.

            if (a.IsMatch(name))        //chicking the condition with the help of if /else statement.
             //IsMatch :indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string.
            {
                Console.WriteLine(name +" this last name is valid .");  //if the conduction is true.
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(name +" this last name is not valid");    //if condition is false.
                Console.ReadLine();
            }
        }
    }
}
