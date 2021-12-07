using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector;
using System.Numerics;

namespace KataVectors
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void Vector_25_Magnitude()
        {
            VectorClass vector = new VectorClass(3, 4);
            Assert.AreEqual(5, vector.Magnitude());
        }

        [TestMethod]
        public void Vector_xy_DotProduct()
        {
            VectorClass vectorOne = new VectorClass(2, 4);
            VectorClass vectorTwo = new VectorClass(1,-3);
            Assert.AreEqual(-10, vectorOne.DotProduct(vectorTwo));
        }

        [TestMethod]
        public void Vector_25_AngleBetween()
        {
            VectorClass vectorOne = new VectorClass(-2, 5);
            VectorClass vectorTwo = new VectorClass(4, 3);
            Assert.AreEqual(74.93, vectorOne.AngleBetween(vectorTwo));
        }
    }
}
