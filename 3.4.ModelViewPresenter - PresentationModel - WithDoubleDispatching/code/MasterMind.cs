using MasterMind.Controllers;
using MasterMind.Views;

namespace MasterMind
{
    public abstract class MasterMind
    {
        private readonly Logic logic;
        private readonly View view;

        protected MasterMind()
        {
            this.logic = new Logic();
            this.view = this.CreateView();
        }

        protected abstract View CreateView();

        public void Play()
        {
            Controller controller;
            do
            {
                controller = this.logic.GetController();
                if (!controller.IsNull())
                {
                    this.view.Interact(controller);
                }
            } while (!controller.IsNull());
        }
    }
}
