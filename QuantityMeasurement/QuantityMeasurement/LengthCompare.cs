using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {

        public readonly UnitConvertor unit;
        public readonly double value;

        public LengthCompare(UnitConvertor unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public LengthCompare AddLength(LengthCompare that)
        {
            return new LengthCompare(UnitConvertor.INCH, this.unit.ConvertedValue(this.value) + that.unit.ConvertedValue(that.value));
        }

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
