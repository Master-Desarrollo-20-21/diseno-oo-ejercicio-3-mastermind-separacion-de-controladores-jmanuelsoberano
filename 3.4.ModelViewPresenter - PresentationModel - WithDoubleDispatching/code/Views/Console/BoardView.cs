using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class BoardView
    {
        private PlayController playController;

        public BoardView(PlayController playController)
        {
            this.playController = playController;
        }

        public void Write()
        {
            Consola.GetInstance().WriteLine();
            Consola.GetInstance()
                .WriteLine(Message.ATTEMPTS.ToString().Replace("#attempts", this.playController.GetAttemps().ToString()));
            new SecretCombinationView(this.playController).WriteLine();
            for (int i = 0; i < this.playController.GetAttemps(); i++)
            {
                new ProposedCombinationView(this.playController).Write(i);
                new ResultView(this.playController).WriteLine(i);
            }

            if (this.playController.IsWinner())
            {
                Consola.GetInstance().WriteLine(Message.WINNER.ToString());
            }
            else if (this.playController.IsLooser())
            {
                Consola.GetInstance().WriteLine(Message.LOOSER.ToString());
            }
        }
    }
}