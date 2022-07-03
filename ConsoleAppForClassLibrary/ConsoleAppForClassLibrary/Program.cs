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
          
            Console.WriteLine("--------------------------------Assignment_1&2");
            Demo obj1 = new Demo();
            obj1.Message();
            obj1.Display();
            LengthHelper obj2 = new LengthHelper();
            Console.WriteLine(obj2.FindLength("Sumitkhinchi"));


            Console.WriteLine("--------------------------------Assignment_3");
            Console.WriteLine("Now increment method will call 2 times");
            Counter.Instance.Increment();
            Counter.Instance.Print();
            Counter.Instance.Increment();
            Counter.Instance.Print();
            Console.WriteLine("Now Decrement method will call");
            Counter.Instance.Decrement();
            Counter.Instance.Print();

            // Assignment_4_Extension method concept
            Console.WriteLine("--------------------------------Assignment_4");
            try
            {
                string test = "12345";
                test.ToCurrency();
                //string test1 = "Hello";
                //test1.ToCurrency();


            }
            catch (someThingWentWrong e)
            {
                Console.WriteLine(e);
            }



            Console.WriteLine("--------------------------------Weekend_Assignment");
            ConsoleReader obj3 = new ConsoleReader();
            obj3.Run();



        }
    }
}
