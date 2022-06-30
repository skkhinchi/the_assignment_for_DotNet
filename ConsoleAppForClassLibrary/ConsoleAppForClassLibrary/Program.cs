using ClassLibrary;


namespace ConsoleAppForClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {    
            // Assignment_1&2
            Demo obj1 = new Demo();
            obj1.Message();
            LengthHelper obj2 = new LengthHelper();
            Console.WriteLine(obj2.FindLength("Sumitkhinchi"));
            Console.WriteLine("--------------------------------");


            // Assignment_3
            Console.WriteLine("Now increment method will call 2 times");
            Counter.Instance.Increment();
            Counter.Instance.Print();
            Counter.Instance.Increment();
            Counter.Instance.Print();
            Console.WriteLine("Now Decrement method will call");
            Counter.Instance.Decrement();
            Counter.Instance.Print();

            Console.Read();
        }
    }
}
