using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResultView : WithLogicView
    {
        public ResultView(Logic logic) : base(logic) {}

        public void WriteLine(int position)
        {
            Consola.GetInstance().WriteLine(Message.RESULT.ToString().Replace("#blacks", this.logic.GetBlacksResult(position).ToString()).Replace("#whites", "" + this.logic.GetWhitesResult(position).ToString()));
        }
    }
}