using ClassLibraryAssignment;


namespace ConsoleApplication_ClassLibraryAssignment
{
    class Program
    {
        static void Main(string [] args)
        {
            Candidates obj1 = new Candidates();
            obj1.displayCandidateMsg();
            Console.WriteLine("Sum = " + obj1.sum(32,8));
            Console.WriteLine("Mul = " + obj1.mul(32, 8));


            Companies obj2 = new Companies();
            obj2.displayCompanyMsg();
            Console.Read();
        }
    }
}
