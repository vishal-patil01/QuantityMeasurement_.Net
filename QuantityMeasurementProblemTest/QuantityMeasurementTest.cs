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
    }
}