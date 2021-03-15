using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Controllers;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class ProposeCommand : Command
    {
        public ProposeCommand(PlayController playController) : base(Message.PROPOSE_COMMAND.ToString(), playController)
        {
        }

        public override void execute()
        {
            this.playController.AddProposedCombination(new ProposedCombinationView(this.playController).Read());
            new BoardView(this.playController).Write();
        }

        public override bool IsActive()
        {
            return true;
        }
    }
}
