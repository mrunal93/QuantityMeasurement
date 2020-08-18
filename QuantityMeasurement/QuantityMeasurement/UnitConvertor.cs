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
