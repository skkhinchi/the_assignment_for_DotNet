using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform;
using Moq;



namespace TestProject
{
    public class ConsoleReaderTest
    {
        ConsoleReader obj = new ConsoleReader();


      [Fact]
        public void TestOnWord()
        {
            Assert.Equal(obj.OnWord(), obj.Run("Hello"));
            Assert.NotNull(obj.Run("Hello"));
        }
        [Fact]
        public void TestOnNUmber()
        {
            Assert.Equal(obj.OnNumber(), obj.Run("1234"));
            Assert.NotNull(obj.Run("12345"));   
        }
        [Fact]
        public void TestOnJunk()
        {
            Assert.Equal(obj.OnJunk(), obj.Run("123$Hello"));
            Assert.NotNull(obj.Run("$umit"));
        }
        [Fact]
        public void NullTest()
        {
            Assert.Null(obj.Run(""));


        }






    }
}
