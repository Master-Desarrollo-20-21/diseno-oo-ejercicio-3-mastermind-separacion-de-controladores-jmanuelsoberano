using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind.Types
{
    public class StateValue
    {
        public static readonly StateValue INITIAL = new StateValue("INITIAL");
        public static readonly StateValue IN_GAME = new StateValue("IN_GAME");
        public static readonly StateValue RESUME = new StateValue("RESUME");
        public static readonly StateValue EXIT = new StateValue("EXIT");

        private String value;

        public static IEnumerable<StateValue> Values
        {
            get
            {
                yield return INITIAL;
                yield return IN_GAME;
                yield return RESUME;
                yield return EXIT;
            }
        }

        private StateValue(String value)
        {
            this.value = value;
        }

        public int Ordinal()
        {
            return StateValue.Values
                .Select((s, i) => s.Equals(this) ? i : -1)
                .Max();
        }

        public override String ToString()
        {
            return this.value;
        }

    }
}
