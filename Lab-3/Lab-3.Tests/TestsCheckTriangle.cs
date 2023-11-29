using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_3.Tests
{
    public class TestsCheckTriangle
    {
        [Fact]
        void checkTriangle_Correct_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 4, 5);

            // Act
            bool actual = triangel.checkTriangle();
            
            // Assert
            Assert.True(actual);
        }
        [Fact]
        void checkTriangle_Zero_A_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(0, 4, 5);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Zero_B_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 0, 5);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Zero_C_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 4, 0);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Negative_A_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(-3, 4, 5);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Negative_B_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, -4, 5);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Negative_C_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 4, -5);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_More_C_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(4, 5, 6);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.True(actual);
        }
        [Fact]
        void checkTriangle_Three_More_B_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(7, 9, 8);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.True(actual);
        }
        [Fact]
        void checkTriangle_Three_More_A_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(10, 8, 9);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.True(actual);
        }
        [Fact]
        void checkTriangle_Three_Less_C_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(9, 10, 20);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_Less_B_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(10, 22, 11);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_Less_A_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(24, 11, 12);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_Equal_C_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(12, 12, 24);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_Equal_B_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(13, 26, 13);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
        [Fact]
        void checkTriangle_Three_Equal_A_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(28, 14, 14);

            // Act
            bool actual = triangel.checkTriangle();

            // Assert
            Assert.False(actual);
        }
    }
}
