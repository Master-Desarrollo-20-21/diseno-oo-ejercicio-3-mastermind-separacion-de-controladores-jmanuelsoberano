using System.Collections.Generic;

namespace MasterMind
{
    public abstract class Combination
    {
        protected List<Color> Colors;

        protected Combination()
        {
            this.Colors = new List<Color>();
        }
    }
}
