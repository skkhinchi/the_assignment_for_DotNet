using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary;

public class ConsoleReader
{
    public delegate string word();
    public delegate string number();
    public delegate string junk();

    public static string OnNumber()
    {
        Console.WriteLine("On Number");
        return "Integer";
    }
    public static string  OnWord()
    {
        Console.WriteLine("On String");
        return "String";
    }

    public static string OnJunk()
    {
        Console.WriteLine("On Junk");
        return "Special";
    }

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

