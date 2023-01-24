namespace ClassLibrary.Test
{
    public class TriangleTest
    {
        private static readonly List<double[]> invalidSides = new()
        {
            new double[] { 7, 3, 4 },
            new double[] { 8, 3, 4 },
            new double[] { 3, 7, 4 },
            new double[] { 3, 8, 4 },
            new double[] { 3, 4, 7 },
            new double[] { 3, 4, 8 }
        };

        [Test]
        public void TriangleCreation_InvalidSides_ArgumentExceptionIsThrown(
            [ValueSource(nameof(invalidSides))] double[] sides)
        {
            // Act
            TestDelegate actual = () => _ = new Triangle(sides[0], sides[1], sides[2]);

            // Arrange
            Assert.Throws<ArgumentException>(actual);
        }

        [Test]
        public void AreaCalculation_ValidSides_Success()
        {
            // Arrange
            var triangle = new Triangle(4, 3, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void CheckingWhetherTriangleIsOrthogonal_RightTriangle_Success()
        {
            // Arrange
            var triangle = new Triangle(4, 5, 3);

            // Act
            var actual = triangle.IsOrthogonal;

            // Assert
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void CheckingWhetherTriangleIsOrthogonal_NonRectangularTriangle_Failure()
        {
            // Arrange
            var triangle = new Triangle(4, 6, 3);

            // Act
            var actual = triangle.IsOrthogonal;

            // Assert
            Assert.That(actual, Is.EqualTo(false));
        }
    }
}