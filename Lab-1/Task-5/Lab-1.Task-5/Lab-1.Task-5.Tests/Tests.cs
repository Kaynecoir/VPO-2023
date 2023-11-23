using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_1.Task_5.Tests
{
    public class Tests
    {
        [Fact]
        public void TestGrad()
        {
            // arrage
            string dirName = "D:\\C#\\code\\5 сем\\5 сем ВПО";
            string fileName = "csproj";
            string expected = 
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-1\\Lab-1.Task-1\\Lab-1.Task-1.Tests\\Lab-1.Task-1.Tests.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-1\\Lab-1.Task-1\\Lab-1.Task-1.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-2\\Lab-1.Task-2\\Lab-1.Task-2.Tests\\Lab-1.Task-2.Tests.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-2\\Lab-1.Task-2\\Lab-1.Task-2.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-3\\Lab-1.Task-3\\Lab-1.Task-3.Tests\\Lab-1.Task-3.Tests.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-3\\Lab-1.Task-3\\Lab-1.Task-3.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-4\\Lab-1.Task-4\\Lab-1.Task-4.Tests\\Lab-1.Task-4.Tests.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-4\\Lab-1.Task-4\\Lab-1.Task-4.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-5\\Lab-1.Task-5\\Lab-1.Task-5.Tests\\Lab-1.Task-5.Tests.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Task-5\\Lab-1.Task-5\\Lab-1.Task-5.csproj\r\n"+
                "D:\\C#\\code\\5 сем\\5 сем ВПО\\Lab-1\\Lab-1.csproj\r\n";


            // act
            List<string> str = Program.Search(dirName, fileName);
            string actual = "";
            foreach (string str2 in str)
            {
                actual = actual + str2 + "\r\n";
            }

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
