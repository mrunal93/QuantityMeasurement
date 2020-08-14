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
            return obj is LengthCompare value && this.value == value.value;
        }
    }
}
