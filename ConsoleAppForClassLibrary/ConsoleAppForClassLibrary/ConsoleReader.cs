using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleAppForClassLibrary 
{ 

public delegate string isWord();
public delegate string isNumber();
public delegate string isJunk();

public class ConsoleReader
{

    public string Run(string o, isWord w, isNumber n, isJunk j)
    {
          Regex specialChar = new Regex("[^A-Za-z0-9]");
          bool hasSpecialChars = specialChar.IsMatch(o);

        if (!string.IsNullOrEmpty(o))
        {
            int tryInt;
            if (Int32.TryParse(o, out tryInt))
            {
                 n();
            }
            else if (hasSpecialChars)
            {
                 j();
            }
            else
            {
                w();
            }

        }
        return null;




    }



}


}
