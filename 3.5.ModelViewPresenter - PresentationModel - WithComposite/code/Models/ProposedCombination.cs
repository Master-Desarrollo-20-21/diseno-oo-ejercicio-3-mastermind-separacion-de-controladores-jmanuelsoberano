using System;
using System.Collections.Generic;
using System.Diagnostics;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class ProposedCombination : Combination
    {
        public Boolean Contains(Color color, int position)
        {
            Debug.Assert(position < this.Colors.Count);

            return this.Colors[position] == color;
        }

        public Boolean Contains(Color color)
        {
            return this.Colors.Contains(color);
        }

        public List<Color> GetColors()
        {
            return this.Colors;
        }
    }
}