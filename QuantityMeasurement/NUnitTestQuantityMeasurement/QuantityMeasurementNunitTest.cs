using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitTestQuantityMeasurement
{
    public class QuantityMeasurementNunitTest
    {
        [Test]
        public void GivenZeroFeetToZeroFeet_ThenCompareQuantity_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(0.0);
            LengthCompare lengthTwo = new LengthCompare(0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }
    }
}