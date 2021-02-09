using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResultView
    {
        private PlayController playController;

        public ResultView(PlayController playController)
        {
            this.playController = playController;
        }

        public void WriteLine(int position)
        {
            Consola.GetInstance().WriteLine(Message.RESULT.ToString()
                .Replace("#blacks", this.playController.GetBlacksResult(position).ToString()).Replace("#whites",
                    "" + this.playController.GetWhitesResult(position).ToString()));
        }
    }
}