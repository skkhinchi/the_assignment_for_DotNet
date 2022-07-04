using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary;

public class ConsoleReader
{

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
                 return OnNumber();
            }
            else if (hasSpecialChars)
            {
               // Console.WriteLine("Special " + OnJunk(o));
                 return OnJunk();
            }
            else
            {
                return OnWord();
               // Console.WriteLine("String " + OnWord(o));
            }
           
        }
        else
        {
            Console.WriteLine("Soemthing went wrong");
            return null;
        }
    }


        public string OnNumber()
        {
        Console.WriteLine("On Number");
            return "Integer";
        }
        public string OnWord()
        {
        Console.WriteLine("On String");
        return "String";
        }

        public string OnJunk()
        {
        Console.WriteLine("On Junk");
        return "Special";
        }
    }

