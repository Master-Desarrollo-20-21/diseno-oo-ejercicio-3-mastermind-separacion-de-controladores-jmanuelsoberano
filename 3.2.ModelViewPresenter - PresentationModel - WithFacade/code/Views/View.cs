using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class View : WithLogicView
    {
        public View(Logic logic) : base(logic) {}

        public void Interact()
        {
            do
            {
                this.Start();
                this.Play();
            } while (this.IsResume());
        }

        protected abstract void Start();
        protected abstract void Play();
        protected abstract bool IsResume();
    }
}