using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class ConsoleView : View
    {
        private StartView _startView;
        private PlayView _playView;
        private ResumeView _resumeView;

        public ConsoleView(StartController startController, PlayController playController, ResumeController resumeController) : base(startController, playController, resumeController)
        {
            this._startView = new StartView(this.StartController);
            this._playView = new PlayView(this.PlayController);
            this._resumeView = new ResumeView(this.ResumeController);
        }

        protected override void Start()
        {
            this._startView.Interact();
        }

        protected override void Play()
        {
            this._playView.Interact();
        }

        protected override bool IsResume()
        {
            return this._resumeView.Interact();
        }
    }
}
