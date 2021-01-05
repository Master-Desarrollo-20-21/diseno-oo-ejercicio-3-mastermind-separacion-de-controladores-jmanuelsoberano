using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class PlayView : WithLogicView
    {
        private BoardView boardView;

        public PlayView(Logic logic) : base(logic) 
        {
            this.boardView = new BoardView(this.logic);
        }

        public void Interact()
        {
            do
            {
                ProposedCombinationView proposedCombinationView = new ProposedCombinationView(this.logic);
                this.logic.AddProposedCombination(proposedCombinationView.Read());
                this.boardView.Write();
            } while (!this.logic.IsFinished());
        }
    }
}
