using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleAppForClassLibrary;

namespace TestProject
{

    public class ConsoleReaderTest
    {

        ConsoleReader obj = new ConsoleReader();
       [Fact]
        public void TestOnWord()
        {

            Assert.Equal("String",obj.Run("SumitKumar", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));

            // Assert.NotNull(obj.Run("Hello"));
        }
     



    }
}
