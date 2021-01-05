using MasterMind.Models;

namespace MasterMind.Controllers
{
    public abstract class Controller
    {
        protected Board Board;
        protected State State;

        public Controller(Board board, State state)
        {
            this.Board = board;
            this.State = state;
        }

        public int GetWidth()
        {
            return Combination.GetWidth();
        }

        public void Next()
        {
            this.State.Next();
        }

        public abstract bool IsNull();

        public abstract void accept(ControllersVisitor controllersVisitor);
    }
}