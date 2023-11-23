using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Lab_1.Task_1;

namespace Lab_1.Task_1.Tests
{
    public class Tests
    {
        [Fact]
        public void PrintTestHello_5()
        {
            // arrage
            string expected = "Hello, World!\nAndhiagain!\n!!!!!";

            // act
            string actual = Program.Print(5);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrintTestHello_25()
        {
            // arrage
            string expected = "Hello, World!\nAndhiagain!\n!!!!!!!!!!!!!!!!!!!!!!!!!";

            // act
            string actual = Program.Print(25);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PrintTestHello_50()
        {
            // arrage
            string expected = "Hello, World!\nAndhiagain!\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // act
            string actual = Program.Print(50);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
