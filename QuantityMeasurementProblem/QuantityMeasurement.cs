// <copyright file="QuantityMeasurement.cs" company="BridgeLabz">
// Copyright (c) Vishal Rajput. All rights reserved.
// </copyright>
namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Converting Quantity From one Unit To Another Unit.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Convert Passed Value To Given Unit.
        /// </summary>
        /// <param name="value">Any double Value </param>
        /// <param name="units">Units Value</param>
        /// <returns>Converted Value</returns>
        public double GetConvertedValue(double value, dynamic units)
        {
            return value * units;
        }

        /// <summary>
        /// Override Equals Method.
        /// </summary>
        /// <param name="obj">Instance Of Any Object</param>
        /// <returns>Return True If Parameter Value Is Equal To Instance Or Its Type</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj.GetType() == this.GetType())
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Override GetHashCode Method.
        /// </summary>
        /// <returns>HashCode Value</returns>
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Convert Passed Value To Given Unit
        /// </summary>
        /// <param name="value">Any Double Value</param>
        /// <param name="unit">Instance Of Temperature</param>
        /// <returns>Converted Value</returns>
        public double GetConvertedValue(double value, Temperature unit)
        {
            return unit == Temperature.CELSIUS ? (value * unit.Value) + 32 : value * unit.Value;
        }
    }
}
