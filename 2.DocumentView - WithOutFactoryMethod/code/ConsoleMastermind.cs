using MasterMind.Models;
using MasterMind.Views.Console;

namespace MasterMind
{
    public class ConsoleMastermind
    {
        private readonly ConsoleView _consoleView;

        public ConsoleMastermind()
        {
            this._consoleView = new ConsoleView(new Board());
        }

        public void Play()
        {
            this._consoleView.Interact();
        }
    }
}
