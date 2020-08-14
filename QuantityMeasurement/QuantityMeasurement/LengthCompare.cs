using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public double value;

        public LengthCompare(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            LengthCompare feet = (LengthCompare)obj;
            return value.CompareTo(feet.value) == 0;
        }
    }
}
