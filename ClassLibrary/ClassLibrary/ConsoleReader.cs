using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static ClassLibrary.DelegatesMethods;

namespace ClassLibrary;

public delegate string word();
public delegate string number();
public delegate string junk();
public class ConsoleReader
{
  
    public string Run(string o,word w, number n, junk j)
    {

        

        Regex specialChar = new Regex("[^A-Za-z0-9]");
        bool hasSpecialChars = specialChar.IsMatch(o);

        if (!string.IsNullOrEmpty(o))
        {
            int tryInt;
            if (Int32.TryParse(o, out tryInt))
            {
                //Console.WriteLine("Interger " + OnNumber(o));
               n();
            }
            else if (hasSpecialChars)
            {
                // Console.WriteLine("Special " + OnJunk(o));
                j();
            }
            else
            {
                w();
                // Console.WriteLine("String " + OnWord(o));
            }

        }
        return null;



       
    }



}

