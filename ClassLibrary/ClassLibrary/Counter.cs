using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public sealed class Counter
    {
        private int count = 0;
        private static Counter instance = null;

        public static Counter Instance
        {
            get
            {
                if (instance == null)
                    instance = new Counter();

                return instance;
            }
        } 
        public int Increment()
        {
            return count++;
        }
        public int Decrement()
        {
            return count--;
        }

        public void Print()
        {
            Console.WriteLine("Counter Value: " + count.ToString());
        }
    }
}
