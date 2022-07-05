using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform;
using Moq;
using static ClassLibrary.ConsoleReader;
using static ClassLibrary.DelegatesMethods;

namespace TestProject
{
    public class ConsoleReaderTest
    {
        ConsoleReader obj = new ConsoleReader();
        word obj1 = new word(OnWord);
        number obj2 = new number(OnNumber);
        junk obj3 = new junk(OnJunk);

       

        [Fact]
        public void TestOnWord()
        {
            Assert.Equal(obj1(), obj.Run("Hello"));
            Assert.NotNull(obj.Run("Hello"));
        }
        [Fact]
        public void TestOnNUmber()
        {
            Assert.Equal(obj2(), obj.Run("1234"));
            Assert.NotNull(obj.Run("12345"));   
        }
        [Fact]
        public void TestOnJunk()
        {
            Assert.Equal(obj3(), obj.Run("123$Hello"));
            Assert.NotNull(obj.Run("$umit"));
        }
        [Fact]
        public void NullTest()
        {
            Assert.Null(obj.Run(""));


        }






    }
}
