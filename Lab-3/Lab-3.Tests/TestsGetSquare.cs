using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_3.Tests
{
    public class TestsGetSquare
    {
        [Fact]
        void getSquare_Correct_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 4, 5);

            // Act
            double actual = triangel.getSquare();

            // Assert
            Assert.Equal<double>(6, actual);
        }
        [Fact]
        void getSquare_Equilateral_tst()
        {
            // Arrange
            double a = 6,
                b = 6,
                c = 6,
                p = (a + b + c) / 2,
                expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Triangle triangel = new Triangle(a, b, c);

            // Act
            double actual = triangel.getSquare();

            // Assert
            Assert.Equal<double>(expected, actual);
        }
        [Fact]
        void getSquare_Isosceles_tst()
        {
            // Arrange
            double a = 6,
                b = 6,
                c = 10,
                p = (a + b + c) / 2,
                expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Triangle triangel = new Triangle(a, b, c);

            // Act
            double actual = triangel.getSquare();

            // Assert
            Assert.Equal<double>(expected, actual);
        }
    }
}
