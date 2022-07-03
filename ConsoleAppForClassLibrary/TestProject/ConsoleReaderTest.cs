using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TestProject
{
    public class ConsoleReaderTest
    {
        ConsoleReader obj = new ConsoleReader();

        [Fact]
        public void Test1()
        {
            Assert.Equal("OnNumber Called", obj.OnNumber());

        }

    }
}
