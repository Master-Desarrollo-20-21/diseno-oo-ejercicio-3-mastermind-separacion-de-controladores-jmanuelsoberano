using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MasterMind
{
    public class ProposedCombination : Combination
    {
        public void Write()
        {
            foreach (Color color in this.Colors)
            {
                color.Write();
            }
        }

        public void Read()
        {
            Error error;
            do
            {
                String proposedColors = Consola.GetInstance().ReadString(Message.ProposedCombination.ToString());
                error = this.CheckError(proposedColors);
                error.WriteLine();
                if (error.IsNull())
                {
                    this.Colors.AddRange(proposedColors.Select(Color.GetInstance));
                }
            } while (!error.IsNull());
        }

        private Error CheckError(String characters)
        {
            if (characters.Length != Result.Width)
            {
                return Error.WrongLength;
            }

            List<Color> colors = new List<Color>();
            for (int i = 0; i < characters.Length; i++)
            {
                Color color = Color.GetInstance(characters[i]);
                if (color.IsNull())
                {
                    return Error.WrongCharacters;
                }
                for (int j = 0; j < i; j++)
                {
                    if (colors[j] == color)
                    {
                        return Error.Duplicated;
                    }
                }
                colors.Add(color);
            }
            return Error.NullError;
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
    }
}
