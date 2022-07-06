using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClassLibrary
{
    public class DelegatesMethods
    {

        public static string OnNumber()
        {
            Console.WriteLine("On Number");
            return "Integer";
        }
        public static string OnWord()
        {
            Console.WriteLine("On String");
            return "String";
        }

        public static string OnJunk()
        {
            Console.WriteLine("On Junk");
            return "Special";
        }


    }

}
