// <copyright file="Temperature.cs" company="BridgeLabz">
// Copyright (c) Vishal Rajput. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Struct Class Containing All Temperature Related Unit Field With Conversion Value
    /// </summary>
    public class Temperature
    {
        public static Temperature CELSIUS = new Temperature(1.8);
        public static Temperature FAHRENHEIT = new Temperature(1.0);

        public double Value = 0.0;

        public Temperature()
        {
        }

        public Temperature(double value)
        {
            this.Value = value;
        }
    }
}
