using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public enum Unit { FEET,INCH}

        public Unit unit;
        public double value;

        public LengthCompare(Unit unit,double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public bool Compare(LengthCompare inchValue)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            LengthCompare length = (LengthCompare)obj;
            return value.CompareTo(length.value) == 0 & unit == length.unit;
        }
    }
}
