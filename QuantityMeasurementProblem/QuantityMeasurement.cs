// <copyright file="QuantityMeasurement.cs" company="BridgeLabz">
// Copyright (c) Vishal Rajput. All rights reserved.
// </copyright>
namespace QuantityMeasurementProblem
{
    using System;

    /// <summary>
    /// Converting Quantity From one Unit To Another Unit.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Convert Passed Value To Feet.
        /// </summary>
        /// <param name="feet">Any Length Value</param>
        /// <returns>Feet Value</returns>
        public double GetFeet(double feet)
        {
            return feet;
        }

        /// <summary>
        /// Override Equals Method.
        /// </summary>
        /// <param name="obj">Instance Of Any Object</param>
        /// <returns>Return True If Parameter Value Is Not Null</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Override GetHashCode Method.
        /// </summary>
        /// <returns>HashCode Value</returns>
        public override int GetHashCode() => base.GetHashCode();
    }
}
