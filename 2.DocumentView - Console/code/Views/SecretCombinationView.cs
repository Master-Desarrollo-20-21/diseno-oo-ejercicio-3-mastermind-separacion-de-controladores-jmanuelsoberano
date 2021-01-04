using MasterMind.Models;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views
{
    public class SecretCombinationView
    {
        public void WriteLine()
        {
            for (int i = 0; i < Combination.GetWidth(); i++)
            {
                Consola.GetInstance().Write(Message.SECRET.ToString());
            }
            Consola.GetInstance().WriteLine();
        }
    }
}