using MasterMind.Views;
using MasterMind.Views.Console;

namespace MasterMind
{
    public class ConsoleMastermind : MasterMind
    {
        protected override View CreateView()
        {
            return new ConsoleView();
        }
    }
}