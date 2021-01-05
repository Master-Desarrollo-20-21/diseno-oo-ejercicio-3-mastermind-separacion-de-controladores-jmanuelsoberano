using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class BoardView : WithLogicView
    {
        private SecretCombinationView _secretCombinationView;
        private ProposedCombinationView _proposedCombinationView;
        private ResultView _resultView;

        public BoardView(Logic logic) : base(logic)
        {
            this._secretCombinationView = new SecretCombinationView(this._logic);
            this._proposedCombinationView = new ProposedCombinationView(this._logic);
            this._resultView = new ResultView(this._logic);
        }

        public void Write()
        {
            Consola.GetInstance().WriteLine();
            Consola.GetInstance()
                .WriteLine(Message.ATTEMPTS.ToString().Replace("#attempts", this._logic.GetAttemps().ToString()));
            this._secretCombinationView.WriteLine();
            for (int i = 0; i < this._logic.GetAttemps(); i++)
            {
                this._proposedCombinationView.Write(i);
                this._resultView.WriteLine(i);
            }

            if (this._logic.IsWinner())
            {
                Consola.GetInstance().WriteLine(Message.WINNER.ToString());
            }
            else if (this._logic.IsLooser())
            {
                Consola.GetInstance().WriteLine(Message.LOOSER.ToString());
            }
        }
    }
}