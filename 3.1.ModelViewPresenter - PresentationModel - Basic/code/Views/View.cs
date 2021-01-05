using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class View
    {
        protected StartController StartController;
        protected PlayController PlayController;
        protected ResumeController ResumeController;

        public View(StartController startController, PlayController playController, ResumeController resumeController)
        {
            this.StartController = startController;
            this.PlayController = playController;
            this.ResumeController = resumeController;
        }

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