using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class PlayView
    {
        private BoardView _boardView;
        private PlayController _playController;

        public PlayView(PlayController playController)
        {
            this._playController = playController;
            this._boardView = new BoardView(this._playController);
        }

        public void Interact()
        {
            do
            {
                ProposedCombinationView proposedCombinationView = new ProposedCombinationView(this._playController);
                this._playController.AddProposedCombination(proposedCombinationView.Read());
                this._boardView.Write();
            } while (!this._playController.IsFinished());
        }
    }
}
