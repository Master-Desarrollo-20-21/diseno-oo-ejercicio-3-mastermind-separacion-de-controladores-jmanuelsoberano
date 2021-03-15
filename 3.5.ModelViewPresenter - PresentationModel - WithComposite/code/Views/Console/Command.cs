using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public abstract class Command : Utils.Command
    {
        protected PlayController playController;

        protected Command(string title, PlayController playController) : base(title)
        {
            this.playController = playController;
        }
    }
}
