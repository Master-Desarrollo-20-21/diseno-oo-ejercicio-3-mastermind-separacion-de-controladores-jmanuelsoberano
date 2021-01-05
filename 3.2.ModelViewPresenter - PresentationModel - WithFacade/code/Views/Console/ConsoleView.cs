using MasterMind.Controllers;

namespace MasterMind.Views.Console
{
    public class ConsoleView : View
    {
        private StartView _startView;
        private PlayView _playView;
        private ResumeView _resumeView;

        public ConsoleView(Logic logic) : base(logic)
        {
            this._startView = new StartView(this._logic);
            this._playView = new PlayView(this._logic);
            this._resumeView = new ResumeView(this._logic);
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
