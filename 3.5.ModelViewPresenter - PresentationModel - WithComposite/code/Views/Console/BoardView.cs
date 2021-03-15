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
            int attempts = this.playController.GetAttemps();
            Consola.GetInstance().WriteLine();
            new MessageView().WriteLine(Message.ATTEMPTS, attempts);
            new SecretCombinationView(this.playController).WriteLine();
            for (int i = 0; i < attempts; i++)
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