using Xunit;
using ClassLibrary;

namespace TestProject
{
    public class UnitTest1
    {
        LengthHelper obj1 = new LengthHelper();

        [Fact]
        public void Test1()
        {
            Assert.Equal(0, obj1.findLength(""));

        }

        [Fact]
        public void Test2()
        {       
           Assert.Equal(3, obj1.findLength("123"));
          
        }

        [Fact]
        public void Test3()
        { 
            Assert.Equal(11, obj1.findLength("12345678910"));
        }
       
        [Fact]
        public void Test4()
        {
            Assert.NotNull("null");
        }

        [Fact]
        public void Test5()
        {
            Assert.Null(null);
        }



    }
}