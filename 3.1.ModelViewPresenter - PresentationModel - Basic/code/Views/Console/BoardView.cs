using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class BoardView
    {
        private PlayController _playController;
        private SecretCombinationView _secretCombinationView;
        private ProposedCombinationView _proposedCombinationView;
        private ResultView _resultView;

        public BoardView(PlayController playController)
        {
            this._playController = playController;
            this._secretCombinationView = new SecretCombinationView(this._playController);
            this._proposedCombinationView = new ProposedCombinationView(this._playController);
            this._resultView = new ResultView(this._playController);
        }

        public void Write()
        {
            Consola.GetInstance().WriteLine();
            Consola.GetInstance()
                .WriteLine(Message.ATTEMPTS.ToString().Replace("#attempts", this._playController.GetAttemps().ToString()));
            this._secretCombinationView.WriteLine();
            for (int i = 0; i < this._playController.GetAttemps(); i++)
            {
                this._proposedCombinationView.Write(i);
                this._resultView.WriteLine(i);
            }

            if (this._playController.IsWinner())
            {
                Consola.GetInstance().WriteLine(Message.WINNER.ToString());
            }
            else if (this._playController.IsLooser())
            {
                Consola.GetInstance().WriteLine(Message.LOOSER.ToString());
            }
        }
    }
}