using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        public double value;

        public Inch(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            Inch inch = (Inch)obj;
            return value.CompareTo(inch.value) == 0;
        }
    }
}
