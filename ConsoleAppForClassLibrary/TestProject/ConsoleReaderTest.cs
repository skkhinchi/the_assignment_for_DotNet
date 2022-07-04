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
        public void Test()
        {
            Assert.Equal(obj.OnWord(), obj.Run("Hello"));

           
        }
        [Fact]
        public void Test1()
        {
            Assert.Equal(obj.OnNumber(), obj.Run("1234"));


        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(obj.OnJunk(), obj.Run("123$Hello"));


        }
        [Fact]
        public void Test3()
        {
            Assert.Null(obj.Run(""));


        }





    }
}
