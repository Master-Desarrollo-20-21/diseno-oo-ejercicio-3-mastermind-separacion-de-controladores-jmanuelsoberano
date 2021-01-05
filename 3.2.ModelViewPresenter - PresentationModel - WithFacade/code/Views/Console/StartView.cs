using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class StartView
    {
        private StartController _startController;

        public StartView(StartController startController)
        {
            this._startController = startController;
        }

        public void Interact()
        {
            Consola.GetInstance().WriteLine(Message.TITLE.ToString());
            new SecretCombinationView(this._startController).WriteLine();
        }
    }
}
