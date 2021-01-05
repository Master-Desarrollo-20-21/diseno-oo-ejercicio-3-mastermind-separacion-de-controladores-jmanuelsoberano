using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class ConsoleView : View
    {
        private StartView startView;
        private PlayView playView;
        private ResumeView resumeView;

        public ConsoleView()
        {
            this.startView = new StartView();
            this.playView = new PlayView();
            this.resumeView = new ResumeView();
        }

        public override void Interact(Controller controller)
        {
            if (controller.GetType() == typeof(StartController))
            {
                this.startView.Interact((StartController) controller);
            } 
            else if (controller.GetType() == typeof(PlayController))
            {
                this.playView.Interact((PlayController) controller);
            }
            else
            {
                this.resumeView.Interact((ResumeController) controller);
            }
        }
    }
}
