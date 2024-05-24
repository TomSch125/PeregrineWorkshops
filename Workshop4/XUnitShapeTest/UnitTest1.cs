using Shapes;

namespace XUnitShapeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void TestImpossibleTraingle() {
            Triangle t = new Triangle(1, 2, 5);
            Assert.False(t.check());
        }

        [Fact]
        public void TestPossibleTriangle() {
            Triangle t = new Triangle(1, 2, 2);
            Assert.True(t.check());
        }

        [Fact]
        public void TestTriangleArea()
        {
            double expected = 1.732;
            Triangle t = new Triangle(2, 2, 2);
            Assert.Equal(expected, Math.Round(t.area(), 3));
        }

        [Fact]
        public void TestTriangleArea2()
        {
            double expected = 6.495;
            Triangle t = new Triangle(3, 7, 5);
            Assert.Equal(expected, Math.Round(t.area(), 3));
        }

        [Fact]
        public void TestTriangleAreaImpossible()
        {
            double expected = -1;
            Triangle t = new Triangle(3, 3, 10);
            Assert.Equal(expected, Math.Round(t.area(), 3));
        }

        [Fact]
        public void TestTrianglePerimiter()
        {
            double expected = 6;
            Triangle t = new Triangle(2, 2, 2);
            Assert.Equal(expected, t.perimeter());
        }

        [Fact]
        public void TestTrianglePerimiter2()
        {
            double expected = 12;
            Triangle t = new Triangle(2, 5, 5);
            Assert.Equal(expected, t.perimeter());
        }

        [Fact]
        public void TestTrianglePerimiterImpossible()
        {
            double expected = -1;
            Triangle t = new Triangle(1, 2, 5);
            Assert.Equal(expected, t.perimeter());
        }

        [Fact]
        public void TestRectangleArea()
        {
            double expected = 12;
            Rectangle r = new Rectangle(3, 4);
            Assert.Equal(expected, r.area());
        }

        [Fact]
        public void TestRectangleArea2()
        {
            double expected = 100;
            Rectangle r = new Rectangle(10, 10);
            Assert.Equal(expected, r.area());
        }

        [Fact]
        public void TestRectanglePerimeter()
        {
            double expected = 14;
            Rectangle r = new Rectangle(3, 4);
            Assert.Equal(expected, r.perimeter());
        }

        [Fact]
        public void TestRectanglePerimeter2()
        {
            double expected = 40;
            Rectangle r = new Rectangle(10, 10);
            Assert.Equal(expected, r.perimeter());
        }

        [Fact]
        public void TestCircleArea() {
            double expected = 28.274;
            Circle c = new Circle(3);
            Assert.Equal(expected, Math.Round(c.area(), 3));
        }

        [Fact]
        public void TestCircleArea2()
        {
            double expected = 452.389;
            Circle c = new Circle(12);
            Assert.Equal(expected, Math.Round(c.area(), 3));
        }

        [Fact]
        public void TestCirclePerimeter()
        {
            double expected = 18.85;
            Circle c = new Circle(3);
            Assert.Equal(expected, Math.Round(c.perimeter(), 2));
        }

        [Fact]
        public void TestCirclePerimeter2()
        {
            double expected = 75.4;
            Circle c = new Circle(12);
            Assert.Equal(expected, Math.Round(c.perimeter(), 1));
        }
    }
}