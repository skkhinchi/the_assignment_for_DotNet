using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryAssignment
{
    public class Candidates
    {
        int i;
        string msg = "Hi, I am Great";

        public int sum(int a, int b)
        {
            Console.WriteLine("calling from Candidate Class");
            i = a + b;
            return i;   
        }
        public int mul(int a, int b)
        {
            i = a * b;
            return i;
        }

        public void displayCandidateMsg()
        { 
                Console.WriteLine(msg);
        }
    }
}
