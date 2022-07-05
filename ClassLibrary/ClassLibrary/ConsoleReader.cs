using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static ClassLibrary.DelegatesMethods;

namespace ClassLibrary;

public class ConsoleReader
{
    public string Run(string o)
    {

        word obj1 = new word(OnWord);
        number obj2 = new number(OnNumber);
        junk obj3 = new junk(OnJunk);

        Regex specialChar = new Regex("[^A-Za-z0-9]");
        bool hasSpecialChars = specialChar.IsMatch(o);

        if (!string.IsNullOrEmpty(o))
        {
            int tryInt;
            if (Int32.TryParse(o, out tryInt))
            {
                //Console.WriteLine("Interger " + OnNumber(o));
                obj2();
            }
            else if (hasSpecialChars)
            {
                // Console.WriteLine("Special " + OnJunk(o));
                obj3();
            }
            else
            {
                obj1();
                // Console.WriteLine("String " + OnWord(o));
            }

        }
        return null;



       
    }



}

