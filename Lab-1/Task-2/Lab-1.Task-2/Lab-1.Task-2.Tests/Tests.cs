using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_1.Task_2.Tests
{
    public class Tests
    {
        [Fact]
        public void TestAgeMin()
        {
            // arrage
            Hum[] hums = new Hum[] { 
                new Hum() { LastName = "1", Name = "1", Age = 2 },
                new Hum() { LastName = "2", Name = "2", Age = 4 },
                new Hum() { LastName = "3", Name = "3", Age = 8 },
            };
            Hum expected = new Hum() { LastName = "1", Name = "1", Age = 2};

            // act
            Hum actual = Program.AgeMin(hums, 3);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAgeMax()
        {
            // arrage
            Hum[] hums = new Hum[] {
                new Hum() { LastName = "1", Name = "1", Age = 2 },
                new Hum() { LastName = "2", Name = "2", Age = 4 },
                new Hum() { LastName = "3", Name = "3", Age = 8 },
            };
            Hum expected = new Hum() { LastName = "3", Name = "3", Age = 8 };

            // act
            Hum actual = Program.AgeMax(hums, 3);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAgeMid()
        {
            // arrage
            Hum[] hums = new Hum[] {
                new Hum() { LastName = "1", Name = "1", Age = 2 },
                new Hum() { LastName = "2", Name = "2", Age = 4 },
                new Hum() { LastName = "3", Name = "3", Age = 8 },
            };
            float expected = (float)14 / 3;

            // act
            float actual = Program.AgeMid(hums, 3);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
