using AreasLib;

namespace AreasLibTests
{
    public  class TriangleTests
    {
        [Theory]
        [InlineData(0, 5, 6)]
        [InlineData(5, 0, 7)]
        [InlineData(6, 3, 0)]
        [InlineData(0, 0, 0)]
        public void Constructor_ZeroArgument_ThrowsArgumentException(float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(-2, 5, 6)]
        [InlineData(5, -3, 7)]
        [InlineData(6, 3, -1)]
        [InlineData(-4, -5, -3)]
        public void Constructor_NegativeArgument_ThrowsArgumentException(float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(12, 5, 6)]
        [InlineData(5, 18, 12)]
        [InlineData(6, 3, 11)]
        public void Constructor_WhenAllSidesNonZeroAndOneSideMoreThanSumOfOthers_ThrowsArgumentException(float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(12, 7, 6)]
        [InlineData(5, 11, 12)]
        [InlineData(6, 3, 8)]
        public void Constructor_WhenEverySideLessThanSumOfOthers_ReturnsNotNullTriangle(float a, float b, float c)
        {
            Assert.NotNull(() => new Triangle(a, b, c));
        }

        [Fact]
        public void GetArea_When345_ReturnsDifferenceWith6LesThan1PowMinus4()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.True(Math.Abs(triangle.GetArea() - 6) < 0.0001);
        }

        [Fact]
        public void GetArea_When467Point2111026_ReturnsDifferenceWith12LesThan1PowMinus4()
        {
            Triangle triangle = new(4, 6, 7.2111026f);
            Assert.True(Math.Abs(triangle.GetArea() - 12) < 0.0001);
        }

        [Theory]
        [InlineData(4, 6, 8.34, 11.1686)]
        [InlineData(17, 11, 9.65743, 49.7214)]
        [InlineData(1243, 1129, 847, 464888.8178)]
        public void GetArea_WithDifferentSides_ReturnsDifferenceWithExpectedLesThan1PowMinus4(float a, float b, float c, double expected)
        {
            Triangle triangle = new(a, b, c);
            Assert.True(Math.Abs(triangle.GetArea() - expected) < 0.0001);
        }
    }
}
