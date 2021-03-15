using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MasterMind.Utils
{
    public class ClosedInterval
    {
        private int min;
        private int max;

        public ClosedInterval(int min, int max)
        {
            Debug.Assert(min <= max);

            this.min = min;
            this.max = max;
        }

        public bool IsIncluded(int value)
        {
            return this.min <= value && value <= this.max;
        }

        public override string ToString()
        {
            return "[" + this.min + ", " + this.max + "]";
        }

	}
}
