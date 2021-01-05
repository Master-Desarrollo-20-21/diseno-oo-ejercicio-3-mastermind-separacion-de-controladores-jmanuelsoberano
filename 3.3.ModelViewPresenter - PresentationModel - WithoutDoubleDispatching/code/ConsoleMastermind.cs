using MasterMind.Controllers;
using MasterMind.Views;
using MasterMind.Views.Console;

namespace MasterMind
{
    public class ConsoleMastermind : MasterMind
    {
        protected override View CreateView(Logic logic)
        {
            return new ConsoleView(logic);
        }
    }
}
