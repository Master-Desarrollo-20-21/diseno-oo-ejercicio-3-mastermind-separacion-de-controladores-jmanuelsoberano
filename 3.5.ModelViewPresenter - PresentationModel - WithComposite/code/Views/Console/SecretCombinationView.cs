using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class SecretCombinationView
    {
        private Controller controller;

        public SecretCombinationView(Controller controller)
        {
            this.controller = controller;
        }

        public void WriteLine()
        {
            for (int i = 0; i < this.controller.GetWidth(); i++)
            {
                Consola.GetInstance().Write(Message.SECRET.ToString());
            }

            Consola.GetInstance().WriteLine();
        }
    }
}