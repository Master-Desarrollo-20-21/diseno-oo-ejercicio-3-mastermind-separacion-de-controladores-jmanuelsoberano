using MasterMind.Controllers;
using MasterMind.Models;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly Logic logic;
        private readonly View view;

        protected MasterMind()
        {
            this.logic = new Logic(new Session());
            this.view = this.CreateView();
        }

        protected abstract View CreateView();

        public void Play()
        {
            this.view.Interact(this.logic);
        }
    }
}