using MasterMind.Models;

namespace MasterMind.Controllers
{
    public abstract class Controller
    {
        protected Board Board;

        public Controller(Board board)
        {
            this.Board = board;
        }

        public int GetWidth()
        {
            return Combination.GetWidth();
        }
    }
}
