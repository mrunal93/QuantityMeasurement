using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {

        public readonly UnitConvertor unit;
        public readonly double value;
        //private Unit unit;
        //private double value;
        //private double CONVERTER_INCH_FEET = 12.0;
        //private double CONVERTER_FEET_YARD = 3.0;

        public LengthCompare(UnitConvertor unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        //public double ConvertTheValue(Unit unit, double value)
        //{
        //    if (unit.Equals(Unit.FEET))
        //    {
        //        return value * 12.0;
        //    }
        //    else if (unit.Equals(Unit.YARD))
        //    {
        //        return value * 36.0;
        //    }
        //    else if (unit.Equals(Unit.CENTIMETER))
        //    {
        //        return value / 2.5;
        //    }

        //    return value;
        //}

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            LengthCompare length = (LengthCompare)obj;
            return Double.Equals(length.unit.ConvertedValue(length.value), this.unit.ConvertedValue(this.value));
        }
    }
}
