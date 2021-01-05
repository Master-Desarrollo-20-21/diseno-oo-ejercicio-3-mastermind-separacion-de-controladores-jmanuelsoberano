using MasterMind.Controllers;
using MasterMind.Views;
using MasterMind.Views.Console;

namespace MasterMind
{
    public class ConsoleMastermind : MasterMind
    {
        protected override View CreateView(StartController startController, PlayController playController, ResumeController resumeController)
        {
            return new ConsoleView(startController, playController, resumeController);
        }
    }
}
