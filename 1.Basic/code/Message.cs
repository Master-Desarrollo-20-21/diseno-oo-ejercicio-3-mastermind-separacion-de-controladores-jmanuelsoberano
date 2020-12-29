using System.Diagnostics;

namespace MasterMind
{

    public class Message
    {
        public static readonly Message Attempts = new Message("#attempts attempt(s): ");
        public static readonly Message Resume = new Message("Do you want to continue");
        public static readonly Message Result = new Message(" --> #blacks blacks and #whites whites");
        public static readonly Message ProposedCombination = new Message("Propose a combination: ");
        public static readonly Message Title = new Message("----- MASTERMIND -----");
        public static readonly Message Winner = new Message("You've won!!! ;-)");
        public static readonly Message Looser = new Message("You've lost!!! :-(");
        public static readonly Message SecretCombination = new Message("****");

        private string _value;

        private Message(string message)
        {
            this._value = message;
        }

        public override string ToString()
        {
            return _value;
        }

        public void Write()
        {
            Consola.GetInstance().Write((this._value));
        }

        public void WriteLine()
        {
            Consola.GetInstance().WriteLine(this._value);
        }

        public void WriteLine(int attempts)
        {
            Debug.Assert(this == Attempts);

            Consola.GetInstance().WriteLine(this._value.Replace("#attempts", "" + attempts));
        }

        public void WriteLine(int blacks, int whites)
        {
            Debug.Assert(this == Result);

            Consola.GetInstance().WriteLine(this._value.Replace("#blacks", "" + blacks).Replace("#whites", "" + whites));
        }

    }
}
