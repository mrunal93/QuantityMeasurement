//-----------------------------------------------------------------------
// <copyright file="QuantityOperation.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mrunal Fulzele</author>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class QuantityOperation
    {

        public readonly UnitConvertor unit;
        public readonly double value;

        public QuantityOperation(UnitConvertor unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        /// <summary>
        /// Adds the length.
        /// </summary>
        /// <param name="that">The that.</param>
        /// <returns>It Perform Addition Operation and return the converted value</returns>
        public QuantityOperation AddLength(QuantityOperation that)
        {
            return new QuantityOperation(UnitConvertor.INCH, this.unit.ConvertedValue(this.value) + that.unit.ConvertedValue(that.value));
        }
        
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            QuantityOperation length = (QuantityOperation)obj;
            return Double.Equals(length.unit.ConvertedValue(length.value), this.unit.ConvertedValue(this.value));
        }
    }
}
