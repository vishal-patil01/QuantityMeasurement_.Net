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
    }
}