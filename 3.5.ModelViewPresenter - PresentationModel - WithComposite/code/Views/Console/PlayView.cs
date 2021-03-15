using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class PlayView
    {
        public void Interact(PlayController playController)
        {
            do
            {
                new PlayMenu(playController).execute();
            } while (!playController.IsFinished());

            playController.NextState();
        }
    }
}