using System;
using MasterMind.Models;

namespace MasterMind.Views
{
    public abstract class View : WithBoardView
    {
        public View(Board board) : base(board) { }

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