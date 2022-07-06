namespace ConsoleAppForClassLibrary

{
    class Program
    {
      
        static void Main(string[] args)
        {   
          
            Console.WriteLine("--------------------------------Weekend_Assignment");
            string o;
            ConsoleReader obj = new ConsoleReader();
             Console.Write("Write input continuously: ");
            while ((o = Console.ReadLine()) != null)
            {
                 // Console.WriteLine("Input : ");
                //string o = Console.ReadLine();
                obj.Run(o, DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk);
            }
        }
    }
}
