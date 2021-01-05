using MasterMind.Controllers;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly View _view;

        protected MasterMind()
        {
            this._view = this.CreateView(new Logic());
        }

        protected abstract View CreateView(Logic logic);

        public void Play()
        {
            this._view.Interact();
        }
    }
}
