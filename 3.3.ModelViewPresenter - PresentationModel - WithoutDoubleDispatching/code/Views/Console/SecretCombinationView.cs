using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class SecretCombinationView : WithLogicView
    {
        public SecretCombinationView(Logic logic) : base(logic) {}

        public void WriteLine()
        {
            for (int i = 0; i < this.logic.GetWidth(); i++)
            {
                Consola.GetInstance().Write(Message.SECRET.ToString());
            }
            Consola.GetInstance().WriteLine();
        }
    }
}