using MasterMind.Models;
using MasterMind.Views;

namespace MasterMind
{
    public class Mastermind
    {
        private View _view;

        public Mastermind()
        {
            this._view = new View(new Board());
        }

        public void Play()
        {
            this._view.Interact();
        }
    }
}
