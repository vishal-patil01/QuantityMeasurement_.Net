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
            double valueInFeet = this.quantityMeasurement.GetFeet(0.0);
            double valueInFeet2 = this.quantityMeasurement.GetFeet(0.0);
            Assert.AreEqual(valueInFeet, valueInFeet2);
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
            QuantityMeasurement quantity1 = new QuantityMeasurement();
            QuantityMeasurement quantity2 = new QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test 1.5: Test To Check Equality On Value.
        /// </summary>
        [Test]
        public void GivenTwoSameValues_WhenCompared_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetFeet(10.0);
            double value2 = this.quantityMeasurement.GetFeet(10.0);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.6: Given 0 Inch and 0 Inch Should Return Same value.
        /// </summary>
        [Test]
        public void GivenTwoInchSameValues_WhenCompared_ShouldReturnEqual()
        {
            double inch1 = this.quantityMeasurement.GetInch(0.0);
            double inch2 = this.quantityMeasurement.GetInch(0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test 1.7: To Check 10 Inch is not equal to 0 Inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenCompared_ShouldReturnNotEqual()
        {
            double inch1 = this.quantityMeasurement.GetInch(0.0);
            double inch2 = this.quantityMeasurement.GetInch(10.0);
            Assert.AreNotEqual(inch1, inch2);
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
            QuantityMeasurement quantity1 = new QuantityMeasurement();
            QuantityMeasurement quantity2 = new QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test 1.11: To Perform Equality Check On Value.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenCompared_ShouldReturnEqual()
        {
            double inch1 = this.quantityMeasurement.GetInch(10.0);
            double inch2 = this.quantityMeasurement.GetInch(10.0);
            Assert.AreEqual(inch2, inch1);
        }
    }
}