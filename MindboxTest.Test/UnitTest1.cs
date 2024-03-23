namespace MindboxTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleSquare_ReturnsExpectedValue()
        {
            Triangle triangle = new(5, 5, 5);

            double result = triangle.Square;

            Assert.Equal(10.825317547305, result, 2);
        }

        [Fact]
        public void TriangleSquare_ZeroSide_ReturnsZero()
        {
            Triangle triangle = new(0, 5, 5);

            double result = triangle.Square;

            Assert.Equal(0, result, 2);
        }

        [Fact]
        public void TriangleIsRight_ReturnsTrue()
        {
            Triangle triangle = new(3, 5, 4);

            bool result = triangle.IsRight;

            Assert.True(result);
        }

        [Fact]
        public void CircleSquare_ReturnsExpectedValue()
        {
            Circle circle = new(16);

            double result = circle.Square;

            Assert.Equal(804.25, result, 2);
        }
    }
}