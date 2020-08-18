using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitTestQuantityMeasurement
{
    public class QuantityMeasurementNunitTest
    {
       
        [Test]
        public void GivenZeroFeetToZeroFeet_ThenCompareQuantity_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET,0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.FEET, 0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroFeetToNull_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 0.0);
            LengthCompare lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenTwoObjects_ThenCheckReference_ShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 0.0);
            LengthCompare lengthTwo = lengthOne;
            Assert.AreEqual(lengthOne,lengthTwo);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvale_Thencheckedtype_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.FEET, 2.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroFeetAndThreeFeet_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.FEET, 5.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroLengthCompareAndZeroLengthCompare_thenCompareQuantity_ShouldReturnEquals()
        {
            LengthCompare LengthOne = new LengthCompare(UnitConvertor.INCH, 0.0);
            LengthCompare LengthCompareTwo = new LengthCompare(UnitConvertor.INCH, 0.0);
            Assert.AreEqual(LengthOne, LengthCompareTwo);
        }

        [Test]
        public void GivenZeroLengthCompareAndNullLengthCompare_thenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConvertor.INCH,0.0);
            LengthCompare LengthCompareTwo = null;
            Assert.AreNotEqual(LengthCompareOne, LengthCompareTwo);
        }

        [Test]
        public void GivenTwoObjectsForLengthCompare_ThenCheckReference_ShouldReturnFalse()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConvertor.INCH,0.0);
            LengthCompare LengthCompareTwo = new LengthCompare(UnitConvertor.INCH,0.0);
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsFalse(toReturn);
        }

        [Test]
        public void GivenTwoObjectsForLengthCompare_ThenCheckReference_ShouldReturnTrue()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConvertor.INCH,0.1);
            LengthCompare LengthCompareTwo = LengthCompareOne;
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsTrue(toReturn);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvaleForLengthCompare_Thencheckedtype_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH,0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH,0.7);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroLengthCompareAndThreeLengthCompare_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH,0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH,0.3);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroInchAndZeroFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 0.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneInchAndOneFeet_ThenCompareQuantity_ShouldNotReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneFeetAndTwelveInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 12.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenTwelveFeetAndOneInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 12.0);
            Assert.IsTrue(lengthTwo.Equals(lengthOne));
        }

        [Test]
        public void GivenOneFeetAndOneFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.FEET, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneInchAndOneInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenThreeFeetAndOneYard_ThenCompareQuantity_ShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 3.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneFeetAndOneYard_ThenCompareQuantity_ShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }
        [Test]
        public void GivenOneInchAndOneYard_ThenCompareQuantity_ShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneYardAnd36Inch_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 36.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given36InchAndOneYard_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 36.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneYardAndThreeFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 3.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given2InchAnd5Centimeter_ThenCompareQuantity_ShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 2.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.CENTIMETER, 5.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given2InchAnd2Inch_ThenAddition_shouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 2.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 2.0);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.INCH, 4.0);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given2FeetAnd2Inch_ThenAddition_shouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.INCH, 2.0);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.INCH, 14.0);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1FeetAnd1Feer_ThenAddition_shouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.FEET, 1.0);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.INCH, 24.0);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given2InchtAnd24Centimeter_ThenAddition_shouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.INCH, 2.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.CENTIMETER, 2.5);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.INCH, 3.0);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1gallonAndLitter_ThenCompareQuantity_ShouldReturnEqual()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.LITRE, 3.78);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.GALLON, 1.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void Given1LitterAnd1000milliLiter_ThenCompareQuantity_ShouldReturnEqual()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.LITRE, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.MILILITRE, 1000.0);
            Assert.AreEqual(lengthTwo, lengthOne);
        }

        [Test]
        public void Given1GallontAndLitter_ThenAddition_shouldReturnEqualsWithvalue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.GALLON, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.LITRE, 3.78);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.LITRE, 7.56);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1LitterAnd1000MilliLiter_ThenAddition_shouldReturnEqualsWithvalue2Litter()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.LITRE, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.MILILITRE, 1000.0);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConvertor.LITRE, 2);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1KilogramAnd1000Gram_ThenCompare_shouldReturnEqualsWithvalue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConvertor.KILOGRAM, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConvertor.GRAM, 1000.0);
            Assert.AreEqual(lengthOne,lengthTwo);
        }

    }
}