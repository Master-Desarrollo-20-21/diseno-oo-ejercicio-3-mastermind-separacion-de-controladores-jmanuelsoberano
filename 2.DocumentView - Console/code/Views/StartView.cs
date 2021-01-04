using MasterMind.Models;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views
{
    public class StartView
    {
        public void Interact()
        {
            Consola.GetInstance().WriteLine(Message.TITLE.ToString());
            new SecretCombinationView().WriteLine();
        }
    }
}
