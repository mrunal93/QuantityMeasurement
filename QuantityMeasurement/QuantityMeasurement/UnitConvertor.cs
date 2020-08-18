using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
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

        private double unitBaseConvertor;
        
        private UnitConvertor(double unitBaseConvertor)
        {
            this.unitBaseConvertor = unitBaseConvertor;
        }

        public double ConvertedValue(double value)
        {
            return this.unitBaseConvertor * value;
        }
    }
}
