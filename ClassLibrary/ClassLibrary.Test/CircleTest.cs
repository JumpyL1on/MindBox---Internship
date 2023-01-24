namespace ClassLibrary.Test
{
    public class CircleTest
    {
        [Test]
        public void CircleCreation_InvalidRadius_ArgumentExceptionIsThrown([Values(-1, 0)] double radius)
        {
            // Act
            TestDelegate actual = () => new Circle(radius);

            // Assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Test]
        public void AreaCalculation_ValidRadius_Success()
        {
            // Arrange
            var circle = new Circle(1);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(Math.PI));
        }
    }
}