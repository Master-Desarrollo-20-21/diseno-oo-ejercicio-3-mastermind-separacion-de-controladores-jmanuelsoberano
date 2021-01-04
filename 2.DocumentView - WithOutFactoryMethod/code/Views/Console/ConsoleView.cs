using System;
using MasterMind.Models;

namespace MasterMind.Views.Console
{
    public class ConsoleView : View
    {
        private StartView _startView;
        private PlayView _playView;
        private ResumeView _resumeView;

        public ConsoleView(Board board) : base(board)
        {
            this._startView = new StartView();
            this._playView = new PlayView(this.Board);
            this._resumeView = new ResumeView(this.Board);
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
