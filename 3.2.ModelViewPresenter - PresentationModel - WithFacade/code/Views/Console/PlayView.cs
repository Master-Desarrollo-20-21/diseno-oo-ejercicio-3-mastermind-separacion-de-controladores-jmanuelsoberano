using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class PlayView : WithLogicView
    {
        private BoardView _boardView;

        public PlayView(Logic logic) : base(logic) 
        {
            this._boardView = new BoardView(this._logic);
        }

        public void Interact()
        {
            do
            {
                ProposedCombinationView proposedCombinationView = new ProposedCombinationView(this._logic);
                this._logic.AddProposedCombination(proposedCombinationView.Read());
                this._boardView.Write();
            } while (!this._logic.IsFinished());
        }
    }
}
