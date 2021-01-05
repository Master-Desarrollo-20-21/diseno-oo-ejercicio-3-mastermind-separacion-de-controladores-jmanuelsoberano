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

        public override void visit(StartController startController)
        {
            this.startView.Interact(startController);
        }

        public override void visit(PlayController playController)
        {
            this.playView.Interact(playController);
        }

        public override void visit(ResumeController resumeController)
        {
            this.resumeView.Interact(resumeController);
        }
    }
}