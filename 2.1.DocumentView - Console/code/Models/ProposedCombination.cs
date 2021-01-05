using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class ProposedCombination : Combination
    {

        public Error CheckError(String combination)
        {
            if (combination.Length != Combination.GetWidth())
            {
                return Error.WRONG_LENGTH;
            }

            List<Color> colors = new List<Color>();
            for (int i = 0; i < combination.Length; i++)
            {
                Color color = Color.GetInstance(combination[i]);
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

        public Boolean Contains(Color color, int position)
        {
            Debug.Assert(position< this.Colors.Count);

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
