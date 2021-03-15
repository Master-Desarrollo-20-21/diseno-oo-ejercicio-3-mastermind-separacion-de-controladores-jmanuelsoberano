using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Controllers;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class RedoCommand : Command
    {
        public RedoCommand(PlayController playController) : base(Message.REDO_COMMAND.ToString(), playController)
        {
        }

        public override void execute()
        {
            this.playController.Redo();
            new BoardView(this.playController).Write();
        }

        public override bool IsActive()
        {
            return this.playController.IsRedoable();
        }
    }
}
