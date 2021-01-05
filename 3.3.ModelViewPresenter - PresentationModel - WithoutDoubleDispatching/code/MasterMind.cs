using MasterMind.Controllers;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly View view;

        protected MasterMind()
        {
            this.view = this.CreateView(new Logic());
        }

        protected abstract View CreateView(Logic logic);

        public void Play()
        {
            this.view.Interact();
        }
    }
}
