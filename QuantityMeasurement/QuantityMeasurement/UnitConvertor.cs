using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{/// <summary>
/// This Class is Used To Compare and convert the Units
/// </summary>
    public class UnitConvertor
    {
        public readonly static UnitConvertor FEET = new UnitConvertor(12.0);
        public readonly static UnitConvertor INCH = new UnitConvertor(1.0);
        public readonly static UnitConvertor YARD = new UnitConvertor(36.0);
        public readonly static UnitConvertor CENTIMETER = new UnitConvertor(0.4);
        public readonly static UnitConvertor LITRE = new UnitConvertor(1.0);
        public readonly static UnitConvertor GALLON = new UnitConvertor(3.78);
        public readonly static UnitConvertor MILILITRE = new UnitConvertor(0.001);
        public static readonly UnitConvertor KILOGRAM = new UnitConvertor(1.0);
        public static readonly UnitConvertor GRAM = new UnitConvertor(0.001);
        public static readonly UnitConvertor TONNE = new UnitConvertor(1000);
        public readonly static UnitConvertor FAHRENHIET = new UnitConvertor(1.0);
        public readonly static UnitConvertor CELCIUS = new UnitConvertor(2.12);

        private  readonly double unitBaseConvertor;
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitConvertor"/> class.
        /// </summary>
        /// <param name="unitBaseConvertor">The unit base convertor.</param>
        private UnitConvertor(double unitBaseConvertor)
        {
            this.unitBaseConvertor = unitBaseConvertor;
        }
        /// <summary>
        /// Converteds the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returnsIt Returns the converted Value ></returns>
        public double ConvertedValue(double value)
        {
            return this.unitBaseConvertor * value;
        }
    }
}
