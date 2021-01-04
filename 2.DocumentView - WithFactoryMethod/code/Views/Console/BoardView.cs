using MasterMind.Models;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class BoardView : WithBoardView
    {
        private SecretCombinationView _secretCombinationView = new SecretCombinationView();

        public BoardView(Board board) : base(board) {}

        public void Write()
        {
            Consola.GetInstance().WriteLine();
            Consola.GetInstance()
                .WriteLine(Message.ATTEMPTS.ToString().Replace("#attempts", this.Board.GetAttemps().ToString()));
            this._secretCombinationView.WriteLine();
            for (int i = 0; i < this.Board.GetAttemps(); i++)
            {
                new ProposedCombinationView(this.Board.GetProposedCombination(i)).Write();
                new ResultView(this.Board.GetResult(i)).WriteLine();
            }

            if (this.Board.IsWinner())
            {
                Consola.GetInstance().WriteLine(Message.WINNER.ToString());
            }
            else if (this.Board.IsLooser())
            {
                Consola.GetInstance().WriteLine(Message.LOOSER.ToString());
            }
        }
    }
}