using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class StartView : WithLogicView
    {
        public StartView(Logic logic) : base(logic) {}

        public void Interact()
        {
            Consola.GetInstance().WriteLine(Message.TITLE.ToString());
            new SecretCombinationView(this._logic).WriteLine();
        }
    }
}
