using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class SecretCombinationView
    {
        private Controller _controllers;

        public SecretCombinationView(Controller controller)
        {
            this._controllers = controller;
        }

        public void WriteLine()
        {
            for (int i = 0; i < this._controllers.GetWidth(); i++)
            {
                Consola.GetInstance().Write(Message.SECRET.ToString());
            }
            Consola.GetInstance().WriteLine();
        }
    }
}