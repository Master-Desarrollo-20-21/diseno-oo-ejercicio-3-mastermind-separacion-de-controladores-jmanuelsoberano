using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class BoardView : WithLogicView
    {
        private SecretCombinationView secretCombinationView;
        private ProposedCombinationView proposedCombinationView;
        private ResultView resultView;

        public BoardView(Logic logic) : base(logic)
        {
            this.secretCombinationView = new SecretCombinationView(this.logic);
            this.proposedCombinationView = new ProposedCombinationView(this.logic);
            this.resultView = new ResultView(this.logic);
        }

        public void Write()
        {
            Consola.GetInstance().WriteLine();
            Consola.GetInstance()
                .WriteLine(Message.ATTEMPTS.ToString().Replace("#attempts", this.logic.GetAttemps().ToString()));
            this.secretCombinationView.WriteLine();
            for (int i = 0; i < this.logic.GetAttemps(); i++)
            {
                this.proposedCombinationView.Write(i);
                this.resultView.WriteLine(i);
            }

            if (this.logic.IsWinner())
            {
                Consola.GetInstance().WriteLine(Message.WINNER.ToString());
            }
            else if (this.logic.IsLooser())
            {
                Consola.GetInstance().WriteLine(Message.LOOSER.ToString());
            }
        }
    }
}