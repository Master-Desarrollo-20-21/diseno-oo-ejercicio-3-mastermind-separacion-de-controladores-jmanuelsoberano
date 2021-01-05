using MasterMind.Models;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views
{
    public class ResultView
    {
        private Result _result;

        public ResultView(Result result)
        {
            this._result = result;
        }

        public void WriteLine()
        {
            Consola.GetInstance().WriteLine(Message.RESULT.ToString().Replace("#blacks", this._result.GetBlacks().ToString()).Replace("#whites", "" + this._result.GetWhites().ToString()));
        }
    }
}