using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class PlayView
    {
        public void Interact(PlayController playController)
        {
            do
            {
                ProposedCombinationView proposedCombinationView = new ProposedCombinationView(playController);
                playController.AddProposedCombination(proposedCombinationView.Read());
                new BoardView(playController).Write();
            } while (!playController.IsFinished());

            playController.Next();
        }
    }
}