using ClassLibrary;

public class someThingWentWrong : Exception
{
    public someThingWentWrong(String errorMessage)
    : base(errorMessage)
    {
    }
}

namespace ConsoleAppForClassLibrary
{
    //Extend class be defined in top level of static class
     //Assignment_4
    public static class XtendClass
    {
       
        public static string ToCurrency(this string s)
        {
            int i = 0;
            bool result = int.TryParse(s, out i);
            if(result)
            {
                string Currency = s.Insert(0, "$");
                Console.WriteLine(Currency);
                return Currency;
            }
            else
            {
                Console.WriteLine("Error");
                throw new someThingWentWrong("Sorry, something went wrong");
               //return "Error";
            }
            
        }
    }

    class Program
    {       
      
        static void Main(string[] args)
        {        
            Console.WriteLine("--------------------------------Weekend_Assignment");
            ConsoleReader obj3 = new ConsoleReader();
            obj3.Run();

        }
    }
}
