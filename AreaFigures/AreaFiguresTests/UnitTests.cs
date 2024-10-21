using AreaFigures;
using System;
using NUnit.Framework;

namespace AreaFiguresTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleAreaCalculation_ShouldReturnCorrectValue()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var area = circle.GetArea();

            // Assert
            Assert.AreEqual(Math.PI * 5 * 5, area, 1e-5);
        }

        [Test]
        public void CircleNegativeRadius_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleAreaCalculation_ShouldReturnCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.AreEqual(6, area, 1e-5);
        }

        [Test]
        public void TriangleInvalidSides_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Test]
        public void TriangleIsRightTriangle_ShouldReturnTrueForValidRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void TriangleIsRightTriangle_ShouldReturnFalseForNonRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}
