using MasterMind.Models;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly View _view;

        protected MasterMind()
        {
            this._view = this.CreateView(new Board());
        }

        protected abstract View CreateView(Board board);

        public void Play()
        {
            this._view.Interact();
        }
    }
}
