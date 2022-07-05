using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class RunClass
    {
        ConsoleReader obj3 = new ConsoleReader();
        public string Run(string o)
        {
            Regex specialChar = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChars = specialChar.IsMatch(o);

            if (!string.IsNullOrEmpty(o))
            {
                int tryInt;
                if (Int32.TryParse(o, out tryInt))
                {
                    //Console.WriteLine("Interger " + OnNumber(o));
                    return obj3.OnNumber();
                }
                else if (hasSpecialChars)
                {
                    // Console.WriteLine("Special " + OnJunk(o));
                    return obj3.OnJunk();
                }
                else
                {
                    return obj3.OnWord();
                    // Console.WriteLine("String " + OnWord(o));
                }

            }
            else
            {
                Console.WriteLine("Soemthing went wrong");
                return null;
            }
        }

    }
}
