using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab_3.Tests
{
    public class TestsDetectTriangle
    {
        [Fact]
        void detectTriangle_Restangular_1_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(3, 4, 5);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(8, actual);
        }
        [Fact]
        void detectTriangle_Restangular_2_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(10, 8, 6);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(8, actual);
        }
        [Fact]
        void detectTriangle_Restangular_3_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(12, 13, 5);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(8, actual);
        }
        [Fact]
        void detectTriangle_Equilateral_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(5, 5, 5);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(3, actual);
        }
        [Fact]
        void detectTriangle_Isosceles_1_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(5, 5, 8);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(1, actual);
        }
        [Fact]
        void detectTriangle_Isosceles_2_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(8, 9, 9);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(1, actual);
        }
        [Fact]
        void detectTriangle_Isosceles_3_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(6, 8, 6);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(1, actual);
        }
        [Fact]
        void detectTriangle_Isosceles_Restangular_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(Math.Sqrt(10), Math.Sqrt(10), Math.Sqrt(20));

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(9, actual);
        }
        [Fact]
        void detectTriangle_Ordinary_tst()
        {
            // Arrange
            Triangle triangel = new Triangle(8, 10, 12);

            // Act
            int actual = triangel.detectTriangle();

            // Assert
            Assert.Equal<int>(4, actual);
        }
    }
}
