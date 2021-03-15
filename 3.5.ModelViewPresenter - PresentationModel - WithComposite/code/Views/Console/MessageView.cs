using System.Diagnostics;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class MessageView
    {
        public void WriteLine(Message message)
        {
            Consola.GetInstance().WriteLine(message.ToString());
        }

        public void WriteLine(Message message, int attempts)
        {
            Debug.Assert(message == Message.ATTEMPTS);

            Consola.GetInstance().WriteLine(message.ToString().Replace("#attempts", attempts.ToString()));
        }

        public void WriteLine(Message message, int blacks, int whites)
        {
            Debug.Assert(message == Message.RESULT);

            Consola.GetInstance().WriteLine(message.ToString().Replace("#blacks", blacks.ToString()).Replace("#whites", whites.ToString()));
        }
    }
}
