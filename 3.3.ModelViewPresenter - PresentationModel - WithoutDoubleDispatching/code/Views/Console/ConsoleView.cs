using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class ConsoleView : View
    {
        private StartView startView;
        private PlayView playView;
        private ResumeView resumeView;

        public ConsoleView(Logic logic) : base(logic)
        {
            this.startView = new StartView(this.logic);
            this.playView = new PlayView(this.logic);
            this.resumeView = new ResumeView(this.logic);
        }

        protected override void Start()
        {
            this.startView.Interact();
        }

        protected override void Play()
        {
            this.playView.Interact();
        }

        protected override bool IsResume()
        {
            return this.resumeView.Interact();
        }
    }
}
