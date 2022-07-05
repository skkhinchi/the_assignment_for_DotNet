using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary;

public class ConsoleReader
{
    public delegate void onWord();
    public delegate void onNumber();
    public delegate void onJunk();

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

