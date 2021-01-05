namespace MasterMind.Types
{

    public class Message
    {
        public static readonly Message ATTEMPTS = new Message("#attempts attempt(s): ");
        public static readonly Message RESUME = new Message("Do you want to continue");
        public static readonly Message RESULT = new Message(" --> #blacks blacks and #whites whites");
        public static readonly Message PROPOSED_COMBINATION = new Message("Propose a combination: ");
        public static readonly Message TITLE = new Message("----- MASTERMIND -----");
        public static readonly Message WINNER = new Message("You've won!!! ;-)");
        public static readonly Message LOOSER = new Message("You've lost!!! :-(");
        public static readonly Message SECRET = new Message("*");

        private string value;

        private Message(string message)
        {
            this.value = message;
        }

        public override string ToString()
        {
            return value;
        }

    }
}
