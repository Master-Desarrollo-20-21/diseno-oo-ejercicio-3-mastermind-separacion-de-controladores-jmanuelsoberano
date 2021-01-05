using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResultView
    {
        private PlayController _playController;

        public ResultView(PlayController playController)
        {
            this._playController = playController;
        }

        public void WriteLine(int position)
        {
            Consola.GetInstance().WriteLine(Message.RESULT.ToString().Replace("#blacks", this._playController.GetBlacksResult(position).ToString()).Replace("#whites", "" + this._playController.GetWhitesResult(position).ToString()));
        }
    }
}