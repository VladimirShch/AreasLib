using AreasLib;

namespace AreasLibTests
{
    public class CircleTests
    {
        [Fact]
        public void Constructor_WithZeroRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Fact]
        public void Constructor_WithPositiveInteger_ReturnsNotNullCircle()
        {
            Assert.NotNull(() => new Circle(5));
        }

        [Fact]
        public void Constructor_WithPositiveFloat_ReturnsNotNullCircle()
        {
            Assert.NotNull(() => new Circle(6.3f));
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(25.3)]
        [InlineData(558.746)]
        [InlineData(float.MaxValue)]
        public void GetArea_WithFloatPositiveRadius_ReturnsDifferenceWith2PiRRLesThan1PowMinus8(float radius)
        {
            Circle circle = new(radius);
            Assert.True(Math.Abs(circle.GetArea() - 2 * Math.PI * radius * radius) < 0.00000001);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(24)]
        [InlineData(10453)]
        [InlineData(int.MaxValue)]
        public void GetArea_WithIntegerRadius_ReturnsDifferenceWith2PiRRLesThan1PowMinus8(float radius)
        {
            Circle circle = new(radius);
            Assert.True(Math.Abs(circle.GetArea() - 2 * Math.PI * radius * radius) < 0.00000001);
        }
    }
}