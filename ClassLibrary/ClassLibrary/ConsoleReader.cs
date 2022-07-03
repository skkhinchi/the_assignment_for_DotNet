using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary;

public class ConsoleReader
{
    public void Run()
    {
        string o = Console.ReadLine();

        Regex specialChar = new Regex("[^A-Za-z0-9]");
        bool hasSpecialChars = specialChar.IsMatch(o);
        if (!string.IsNullOrEmpty(o))
        {
            int tryInt;
            if (Int32.TryParse(o, out tryInt))
            {
                Console.WriteLine("Interger " + OnNumber(o));
                // return OnNumber(o);
            }
            else if (hasSpecialChars)
            {
                Console.WriteLine("Special " + OnJunk(o));
                // return OnJunk(o);
            }
            else
            {
                //return OnWord(o);
                Console.WriteLine("String " + OnWord(o));
            }
        }
    }


        public string OnNumber(string a)
        {
            return a;
        }
        public string OnWord(string a)
        {
            return a;
        }

        public string OnJunk(string a)
        {
            return a;
        }
    }

