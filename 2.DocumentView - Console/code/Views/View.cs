using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Models;

namespace MasterMind.Views
{
    public class View : WithBoardView
    {
        private StartView _startView;
        private PlayView _playView;
        private ResumeView _resumeView;
        
        public View(Board board) : base(board)
        {
            this._startView = new StartView(this.Board);
            this._playView = new PlayView(this.Board);
            this._resumeView = new ResumeView(this.Board);
        }

        public void Interact()
        {
            do
            {
                this._startView.Interact();
                this._playView.Interact();
            } while (this._resumeView.Interact());
        }
    }
}
