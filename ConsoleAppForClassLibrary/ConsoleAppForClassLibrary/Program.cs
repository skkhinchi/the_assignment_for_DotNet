using ClassLibrary;


namespace ConsoleAppForClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            obj1.message();


            LengthHelper obj2 = new LengthHelper();
            Console.WriteLine(obj2.findLength("Sumit"));

            Console.Read();
        }
    }
}
