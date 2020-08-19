using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitTestQuantityMeasurement
{
    public class QuantityMeasurementNunitTest
    {
       
        [Test]
        public void GivenZeroFeetToZeroFeet_ThenCompareQuantity_ShouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET,0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.FEET, 0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroFeetToNull_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 0.0);
            QuantityOperation lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenTwoObjects_ThenCheckReference_ShouldReturnFalse()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 0.0);
            QuantityOperation lengthTwo = lengthOne;
            Assert.AreEqual(lengthOne,lengthTwo);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvale_Thencheckedtype_ShouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.FEET, 2.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroFeetAndThreeFeet_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.FEET, 5.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroLengthCompareAndZeroLengthCompare_thenCompareQuantity_ShouldReturnEquals()
        {
            QuantityOperation LengthOne = new QuantityOperation(UnitConvertor.INCH, 0.0);
            QuantityOperation LengthCompareTwo = new QuantityOperation(UnitConvertor.INCH, 0.0);
            Assert.AreEqual(LengthOne, LengthCompareTwo);
        }

        [Test]
        public void GivenZeroLengthCompareAndNullLengthCompare_thenCompareQuantity_ShouldReturnNotEquals()
        {
            QuantityOperation LengthCompareOne = new QuantityOperation(UnitConvertor.INCH,0.0);
            QuantityOperation LengthCompareTwo = null;
            Assert.AreNotEqual(LengthCompareOne, LengthCompareTwo);
        }

        [Test]
        public void GivenTwoObjectsForLengthCompare_ThenCheckReference_ShouldReturnFalse()
        {
            QuantityOperation LengthCompareOne = new QuantityOperation(UnitConvertor.INCH,0.0);
            QuantityOperation LengthCompareTwo = new QuantityOperation(UnitConvertor.INCH,0.0);
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsFalse(toReturn);
        }

        [Test]
        public void GivenLenghtInInchForLengthCompare_ThenCheckReference_ShouldReturnTrue()
        {
            QuantityOperation LengthCompareOne = new QuantityOperation(UnitConvertor.INCH,0.1);
            QuantityOperation LengthCompareTwo = LengthCompareOne;
            bool toReturn = System.Object.ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsTrue(toReturn);
        }

        [Test]
        public void GivenTwoObjectWithDifferentvaleForLengthCompare_Thencheckedtype_ShouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH,0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH,0.7);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [Test]
        public void GivenZeroLengthCompareAndThreeLengthCompare_ThenCompareQuantity_ShouldReturnNotEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH,0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH,0.3);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void GivenZeroInchAndZeroFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 0.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 0.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneInchAndOneFeet_ThenCompareQuantity_ShouldNotReturnFalse()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneFeetAndTwelveInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 12.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenTwelveFeetAndOneInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 12.0);
            Assert.IsTrue(lengthTwo.Equals(lengthOne));
        }

        [Test]
        public void GivenOneFeetAndOneFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.FEET, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneInchAndOneInch_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenThreeFeetAndOneYard_ThenCompareQuantity_ShouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 3.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneFeetAndOneYard_ThenCompareQuantity_ShouldReturnFalse()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }
        [Test]
        public void GivenOneInchAndOneYard_ThenCompareQuantity_ShouldReturnFalse()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneYardAnd36Inch_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 36.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given36InchAndOneYard_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 36.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void GivenOneYardAndThreeFeet_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 3.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given2InchAnd5Centimeter_ThenCompareQuantity_ShouldReturnTrue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 2.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.CENTIMETER, 5.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [Test]
        public void Given2InchAnd2Inch_ThenAddition_shouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 2.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 2.0);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.INCH, 4.0);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given2FeetAnd2Inch_ThenAddition_shouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.INCH, 2.0);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.INCH, 14.0);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1FeetAnd1Feer_ThenAddition_shouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.FEET, 1.0);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.INCH, 24.0);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given2InchtAnd24Centimeter_ThenAddition_shouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.INCH, 2.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.CENTIMETER, 2.5);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.INCH, 3.0);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1gallonAndLitter_ThenCompareQuantity_ShouldReturnEqual()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.LITRE, 3.78);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.GALLON, 1.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void Given1LitterAnd1000milliLiter_ThenCompareQuantity_ShouldReturnEqual()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.LITRE, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.MILILITRE, 1000.0);
            Assert.AreEqual(lengthTwo, lengthOne);
        }

        [Test]
        public void Given1GallontAndLitter_ThenAddition_shouldReturnEqualsWithvalue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.GALLON, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.LITRE, 3.78);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.LITRE, 7.56);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1LitterAnd1000MilliLiter_ThenAddition_shouldReturnEqualsWithvalue2Litter()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.LITRE, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.MILILITRE, 1000.0);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.LITRE, 2);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given1KilogramAnd1000Gram_ThenCompare_shouldReturnEqualsWithvalue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.KILOGRAM, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.GRAM, 1000.0);
            Assert.AreEqual(lengthOne,lengthTwo);
        }

        [Test]
        public void Given1TonneAnd1000Kilogram_ThenCompare_shouldReturnEqualsWithvalue()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.TONNE, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.KILOGRAM, 1000.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [Test]
        public void Given1TonneAnd1000Gram_ThenAddition_shouldReturnEqualsWithvalue10001Kilogram()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.TONNE, 1.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.GRAM, 1000.0);
            QuantityOperation ExpectedInInch = new QuantityOperation(UnitConvertor.KILOGRAM, 1001);
            QuantityOperation additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [Test]
        public void Given212FahrenheitAnd100Celsius_ThenCompare_shouldReturnEquals()
        {
            QuantityOperation lengthOne = new QuantityOperation(UnitConvertor.FAHRENHIET, 212.0);
            QuantityOperation lengthTwo = new QuantityOperation(UnitConvertor.CELCIUS, 100.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }
    }
}