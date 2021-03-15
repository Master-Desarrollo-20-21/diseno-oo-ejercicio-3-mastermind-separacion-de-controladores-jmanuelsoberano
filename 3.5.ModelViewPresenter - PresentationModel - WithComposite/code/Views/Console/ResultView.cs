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
            new MessageView().WriteLine(Message.RESULT, this.playController.GetBlacksResult(position), this.playController.GetWhitesResult(position));
        }
    }
}