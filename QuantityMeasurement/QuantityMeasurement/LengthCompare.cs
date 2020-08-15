using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public enum Unit { FEET,INCH}

        private Unit unit;
        private double value;
        private double FeetToInch = 12.0;
        private double InchToFeet = 12.0;

        public LengthCompare(Unit unit,double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public bool Compare(LengthCompare inchValue)
        {
            if (this.unit.Equals(inchValue.unit))
            {
                return this.Equals(inchValue);
            }
            if (this.unit.Equals(Unit.FEET) && inchValue.unit.Equals(Unit.INCH))
            {
                return inchValue.value.CompareTo(this.value * FeetToInch) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && inchValue.unit.Equals(Unit.FEET))
            {
                return inchValue.value.CompareTo(this.value / InchToFeet) == 0;
            }

            return false;
        }
    }
}
