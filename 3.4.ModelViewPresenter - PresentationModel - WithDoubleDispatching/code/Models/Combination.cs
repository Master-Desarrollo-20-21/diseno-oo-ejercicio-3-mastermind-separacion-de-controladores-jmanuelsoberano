using System.Collections.Generic;
using MasterMind.Types;

namespace MasterMind.Models
{
    public abstract class Combination
    {
        private static readonly int WIDTH = 4;
        protected List<Color> Colors;

        protected Combination()
        {
            this.Colors = new List<Color>();
        }
        public static int GetWidth()
        {
            return Combination.WIDTH;
        }
    }
}
