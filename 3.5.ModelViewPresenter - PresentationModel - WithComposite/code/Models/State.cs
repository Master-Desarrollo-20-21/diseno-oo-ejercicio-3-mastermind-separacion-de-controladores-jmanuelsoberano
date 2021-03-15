using System.Linq;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class State
    {
        private StateValue stateValue;

        public State()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.stateValue = StateValue.INITIAL;
        }

        public void Next()
        {
            this.stateValue = StateValue.Values.ToList()[this.stateValue.Ordinal() + 1];
        }

        public StateValue GetValueState()
        {
            return this.stateValue;
        }
    }
}