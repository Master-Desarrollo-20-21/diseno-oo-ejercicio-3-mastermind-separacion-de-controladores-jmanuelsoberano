using MasterMind.Controllers;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class UndoCommand : Command
    {
        public UndoCommand(PlayController playController) : base(Message.UNDO_COMMAND.ToString(), playController)
        {
        }

        public override void execute()
        {
            this.playController.Undo();
            new BoardView(this.playController).Write();
        }

        public override bool IsActive()
        {
            return this.playController.IsUndoable();
        }
    }
}
