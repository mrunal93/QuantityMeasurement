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

        [Test]
        public void GivenZeroFeetToNull_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(0.0);
            LengthCompare lengthTwo = new LengthCompare(1.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenTwoObjects_ThenCheckReference_ShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(0.0);
            LengthCompare lengthTwo = new LengthCompare(0.0);
            bool toReturn = System.Object.ReferenceEquals(lengthOne, lengthTwo);
            Assert.IsFalse(toReturn);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvale_Thencheckedtype_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(0.0);
            LengthCompare lengthTwo = new LengthCompare(0.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }
    }
}