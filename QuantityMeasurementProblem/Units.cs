// <copyright file="Units.cs" company="BridgeLabz">
// Copyright (c) Vishal Rajput. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Struct Class Containing All Units Field With Conversion Value
    /// </summary>
    public struct Units
    {
        public const double INCH = 1.0;
        public const double FEET_TO_INCH = 12.0;
        public const double YARD_TO_INCH = 36.0;
        public const double CENTIMETER_TO_INCH = 1 / 2.5;

        public const double LITRE = 1.0;
        public const double MILLILITER_TO_LITRE = 1.0 / 1000;
        public const double GALLON_TO_LITRE = 3.785;

        public const double KILLOGRAM = 1.0;
        public const double GRAM_TO_KILLOGRAM = 1.0 / 1000;
        public const double TON_TO_KILLOGRAM = 1000.0;
    }
}
