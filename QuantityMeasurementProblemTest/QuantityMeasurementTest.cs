// <copyright file="QuantityMeasurementTest.cs" company="BridgeLabz">
// Copyright (c) Vishal Rajput. All rights reserved.
// </copyright>
namespace QuantityMeasurementProblemTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// Class to Test QuantityMeasurement.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Instance Variable Of <see cref="QuantityMeasurement"/> class.
        /// </summary>
        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// Setup Method To Initializes a new instance of the <see cref="QuantityMeasurement"/> class.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// Test 1.1: Given 0 Feet and 0 Feet Should Return Same value.
        /// </summary>
        [Test]
        public void GivenTwoFeetWithSameValues_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.2: To Check if Object is null.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_WhenChecked_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.3:Test To Check Equality On Object Reference.
        /// </summary>
        [Test]
        public void GivenReferenceObject_WhenEqual_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test 1.4:Test To Check Equality On Instance Type.
        /// </summary>
        [Test]
        public void GivenTwoType_WhenTypeIsSame_ShouldReturnTrue()
        {
            QuantityMeasurement firstExpectedValue = new QuantityMeasurement();
            QuantityMeasurement secondExpectedValue = new QuantityMeasurement();
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.5: Test To Check Equality On Value.
        /// </summary>
        [Test]
        public void GivenTwoSameValues_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(10.0, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(10.0, Length.FEET_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.6: Given 0 Inch and 0 Inch Should Return Same value.
        /// </summary>
        [Test]
        public void GivenTwoInchSameValues_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(0.0, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(0.0, Length.INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.7: To Check 10 Inch is not equal to 0 Inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenCompared_ShouldReturnNotEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(0.0, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(10.0, Length.INCH);
            Assert.AreNotEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.8: To Check is Object is null.
        /// </summary>
        [Test]
        public void GivenNullValues_WhenChecked_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test 1.9: Test To Check Equality On Object Reference.
        /// </summary>
        [Test]
        public void GivenReference_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test 1.10: Test To Check Equality On Type.
        /// </summary>
        [Test]
        public void GivenClassReferences_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurement firstExpectedValue = new QuantityMeasurement();
            QuantityMeasurement secondExpectedValue = new QuantityMeasurement();
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test 1.11: To Perform Equality Check On Value.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(10.0, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(10.0, Length.INCH);
            Assert.AreEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.12: To Perform Equality Check On Value.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroInch_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(0, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(0, Length.INCH);
            Assert.AreEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.13: To Check 1 Feet is not equal to 1 Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneInch_WhenCompared_ShouldReturnNotEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.INCH);
            Assert.AreNotEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.14: To Check 1 Inch is not equal to 1 Feet.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneFeet_WhenCompared_ShouldReturnNotEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            Assert.AreNotEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.15: To Check 1 Feet is equal to 12 Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwelveInch_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            Assert.AreNotEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.16: To Check 12 Inch is equal to 1 Feet.
        /// </summary>
        [Test]
        public void GivenTwelveInchAndOneFeet_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(12, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            Assert.AreEqual(secondExpectedValue, firstExpectedValue);
        }

        /// <summary>
        /// Test 1.17: check equality for values of 3Feet And 1Yard.
        /// </summary>
        [Test]
        public void GivenThreeFeetandOneYardValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(3.0, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1.0, Length.YARD_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Feet is not equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenOneFeetandOneYardValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.YARD_TO_INCH);
            Assert.AreNotEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Inch is not equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenOneInchandOneYardValue_WhenCompared_ShouldReturnNotEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.YARD_TO_INCH);
            Assert.AreNotEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 36 Inch is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenThirtysixInchandOneYardValue_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(36, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.YARD_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 3 Feet is equal to 1 Yard.
        /// </summary>
        [Test]
        public void GivenThreeFeetAndOneYardValue_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(3, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.YARD_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 2 Inch is equal to 5 Centimeter.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCentimeterValue_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(2, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(5, Length.CENTIMETER_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 0 Inch is equal to 0 Centimeter.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroCentimeterValue_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(0, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(0, Length.CENTIMETER_TO_INCH);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 2 Inch Added to 2 Inch is equal to 4.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnFour()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(2, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(2, Length.INCH);
            Assert.AreEqual(4, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Feet Added to 2 Inch is equal to 14Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnFourteen()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(2, Length.INCH);
            Assert.AreEqual(14, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Feet Added to 1 Feet is equal to 24Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnTwentyFour()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Length.FEET_TO_INCH);
            Assert.AreEqual(24, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 2 Inch Added to 2.5 Centimeter is equal to 3Centimeter.
        /// </summary>
        [Test]
        public void GivenTwoInchTwoAndPointFiveCentimeter_WhenAdded_ShouldReturnThreeCentimeter()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(2, Length.INCH);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(2.5, Length.CENTIMETER_TO_INCH);
            Assert.AreEqual(3, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Gallon And 3.75 liter is equal.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreePointSeventyEighty_WhenCompared_ShouldReturnEqual()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Volume.GALLON_TO_LITRE);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(3.785, Volume.LITRE);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Gallon Added to 3.78 Liter is equal to 7.57Liter.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreePointSeventyEightLitre_WhenAdded_ShouldReturnSevenPointFiftySevenLitre()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Volume.GALLON_TO_LITRE);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(3.785, Volume.LITRE);
            Assert.AreEqual(7.57, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Liter Added to 1000 Milliliter is equal to 2Liter.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneThousandMiliLitre_WhenAdded_ShouldReturnTwoLitre()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Volume.LITRE);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1000, Volume.MILLILITER_TO_LITRE);
            Assert.AreEqual(2.0, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 KG When Compared to 1000 Gram When Compared Then Returns Is Equals.
        /// </summary>
        [Test]
        public void GivenOneKillogramAndOneThousandGrams_WhenCompared_ShouldReturnEquals()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Weight.KILLOGRAM);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1000, Weight.GRAM_TO_KILLOGRAM);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Ton Compared to 1000 Kilogram When Compared Then Returns Is Equals.
        /// </summary>
        [Test]
        public void GivenOneThousandKillogramAndOneTon_WhenCompared_ShouldReturnEquals()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Weight.TON_TO_KILLOGRAM);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1000, Weight.KILLOGRAM);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }

        /// <summary>
        /// Test To Check 1 Ton And to 1000 Gram When Added Then Returns 1001KG.
        /// </summary>
        [Test]
        public void GivenOneThousandGramAndAndOneTon_WhenAdded_ShouldReturnOneThousandOneKG()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(1000, Weight.GRAM_TO_KILLOGRAM);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(1, Weight.TON_TO_KILLOGRAM);
            Assert.AreEqual(1001, firstExpectedValue + secondExpectedValue);
        }

        /// <summary>
        /// Given 212 Fahrenheit And 100 Celsius When Compared Then Return Is Equal.
        /// </summary>
        [Test]
        public void GivenTwoOneTwoFahrehneitAndHundredCelsius_WhenCompare_ShouldReturnTrue()
        {
            double firstExpectedValue = this.quantityMeasurement.GetConvertedValue(212, Temperature.FAHRENHEIT);
            double secondExpectedValue = this.quantityMeasurement.GetConvertedValue(100, Temperature.CELSIUS);
            Assert.AreEqual(firstExpectedValue, secondExpectedValue);
        }
    }
}