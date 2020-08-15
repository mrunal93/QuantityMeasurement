using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitTestQuantityMeasurement
{
    public class QuantityMeasurementNunitTest
    { 
        [Test]
        public void GivenZeroFeetToNull_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenTwoObjects_ThenCheckReference_ShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.FEET, 1.0);
            bool toReturn = System.Object.ReferenceEquals(lengthOne, lengthTwo);
            Assert.IsFalse(toReturn);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvale_Thencheckedtype_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.FEET, 2.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroFeetAndThreeFeet_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.FEET, 5.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroLengthCompareAndNullLengthCompare_thenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare LengthCompareOne = new LengthCompare(LengthCompare.Unit.INCH,0.0);
            LengthCompare LengthCompareTwo = null;
            Assert.AreNotEqual(LengthCompareOne, LengthCompareTwo);
        }

        [Test]
        public void GivenTwoObjectsForLengthCompare_ThenCheckReference_ShouldReturnFalse()
        {
            LengthCompare LengthCompareOne = new LengthCompare(LengthCompare.Unit.INCH,0.0);
            LengthCompare LengthCompareTwo = new LengthCompare(LengthCompare.Unit.INCH,0.0);
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsFalse(toReturn);
        }

        [Test]
        public void GivenTwoObjectsForLengthCompare_ThenCheckReference_ShouldReturnTrue()
        {
            LengthCompare LengthCompareOne = new LengthCompare(LengthCompare.Unit.INCH,0.1);
            LengthCompare LengthCompareTwo = LengthCompareOne;
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsTrue(toReturn);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvaleForLengthCompare_Thencheckedtype_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.INCH,0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.INCH,0.7);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroLengthCompareAndThreeLengthCompare_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.INCH,0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.INCH,0.3);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroInchAndZeroFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.INCH, 0.0);
            bool compareCheck = lengthOne.Compare(lengthTwo);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void GivenOneInchAndOneFeet_ThenCompareQuantity_ShouldNotReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.INCH, 1.0);
            bool compareCheck = lengthOne.Compare(lengthTwo);
            Assert.IsFalse(compareCheck);
        }
    }
}