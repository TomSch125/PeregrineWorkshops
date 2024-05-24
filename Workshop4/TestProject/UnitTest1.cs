namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2() {
            int expected = 2;
            int actual = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}