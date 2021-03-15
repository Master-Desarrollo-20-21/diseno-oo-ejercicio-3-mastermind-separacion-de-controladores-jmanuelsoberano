using System;
using System.Collections.Generic;
using System.Diagnostics;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class ProposedCombination : Combination
    {
        public ProposedCombination(List<Color> colors)
        {
            this.Colors = colors;
        }

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

        public Error GetError()
        {
            if (this.Colors.Count != Combination.GetWidth())
            {
                return Error.WRONG_LENGTH;
            }

            List<Color> colors = new List<Color>();
            for (int i = 0; i < this.Colors.Count; i++)
            {
                Color color = this.Colors[i];
                if (color.IsNull())
                {
                    return Error.WRONG_CHARACTERS;
                }

                for (int j = 0; j < i; j++)
                {
                    if (colors[j] == color)
                    {
                        return Error.DUPLICATED;
                    }
                }

                colors.Add(color);
            }

            return Error.NULL;
        }

        public override string ToString()
        {
            return Color.GetInitials(this.Colors);
        }
    }
}