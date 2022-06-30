using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClassLibrary;

namespace TestProject
{
    public class CounterTest
    {
         [Fact]
        public void TestIncrement()
        {
            Assert.NotEqual(Counter.Instance.Increment(), Counter.Instance.Increment());

        }
        [Fact]
        public void TestIncrement2()
        {
            Assert.Equal(Counter.Instance.Increment()+1, Counter.Instance.Increment());

        }

        [Fact]
        public void TestDecrement()
        {
            Assert.NotEqual(Counter.Instance.Increment() , Counter.Instance.Increment());

        }

    }
}