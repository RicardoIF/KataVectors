using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestVectors
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMagnitude()
        {
            Vectors.Vector vector = new Vectors.Vector(20, 25);
            double result = vector.Magnitude();
            Assert.AreEqual(result, 32,01562);
        }
        [TestMethod]
        public void TestDotProduct()
        {
            Vectors.Vector vector = new Vectors.Vector(20, 25);
            Vectors.Vector vector1 = new Vectors.Vector(20, 45);

            double result = vector.DotProduct(vector, vector1);
            Assert.AreEqual(result, 1525);
        }
        [TestMethod]
        public void TestAngleBetween()
        {
            Vectors.Vector vector = new Vectors.Vector(20, 25);
            Vectors.Vector vector1 = new Vectors.Vector(20, 45);

            double result = vector.AngleBetween(vector, vector1);
            Assert.AreEqual(result, 14,697319279511907);
        }
    }
}
