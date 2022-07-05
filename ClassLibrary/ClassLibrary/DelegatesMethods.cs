using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DelegatesMethods
    {

        public delegate string word();
        public delegate string number();
        public delegate string junk();

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
