using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_1.Task_3.Tests
{
    public class Tests
    {
        [Fact]
        public void TestS_01_01_ret001()
        {
            // arrage
            float a = 0.1f, b = 0.1f;
            float expected = 0.1f*0.1f;

            // act
            float actual = Program.S(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestS_3_3_ret001()
        {
            // arrage
            float a = 3f, b = 3f;
            float expected = 9f;

            // act
            float actual = Program.S(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
