using MasterMind.Controllers;
using MasterMind.Models;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly View _view;

        protected MasterMind()
        {
            Board board = new Board();
            this._view = this.CreateView(new StartController(board), new PlayController(board), new ResumeController(board));
        }

        protected abstract View CreateView(StartController startController, PlayController playController, ResumeController resumeController);

        public void Play()
        {
            this._view.Interact();
        }
    }
}
