using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class StartView
    {
        public void Interact(StartController startController)
        {
            Consola.GetInstance().WriteLine(Message.TITLE.ToString());
            new SecretCombinationView(startController).WriteLine();
            startController.NextState();
        }
    }
}