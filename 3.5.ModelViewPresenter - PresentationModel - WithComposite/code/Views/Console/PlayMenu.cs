using MasterMind.Controllers;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class PlayMenu : Menu
    {
        public PlayMenu(PlayController playController)
        {
            this.AddCommand(new ProposeCommand(playController) );
            this.AddCommand(new UndoCommand(playController));
            this.AddCommand(new RedoCommand(playController));
        }
    }
}
