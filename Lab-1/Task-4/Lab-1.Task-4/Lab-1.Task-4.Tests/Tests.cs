using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_1.Task_4.Tests
{
    public class Tests
    {
        [Fact]
        public void TestGrad()
        {
            // arrage
            string expected = "";
            for (int i = 255; i >= 0; i--) expected += $"<div style=\"background-color:rgb({i}, {i}, {i}); color:rgb({i}, {i}, {i});\">{i}</div>";

            // act
            string actual = Program.Grad();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
