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

            Assert.Equal("On String", obj.Run("SUmit", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk););

            Assert.NotNull(obj.Run("Hello", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));
        }

        [Fact]
        public void TestOnNumber()
        {

            Assert.Equal("Number", obj.Run("1234", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));

            Assert.NotNull(obj.Run("1234", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));
        }
        [Fact]
        public void TestOnJunk()
        {

            Assert.Equal("Junk", obj.Run("Hi$umit", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));

             Assert.NotNull(obj.Run("Hi$umit", DelegatesMethods.OnWord, DelegatesMethods.OnNumber, DelegatesMethods.OnJunk));
        }
       



    }
}
