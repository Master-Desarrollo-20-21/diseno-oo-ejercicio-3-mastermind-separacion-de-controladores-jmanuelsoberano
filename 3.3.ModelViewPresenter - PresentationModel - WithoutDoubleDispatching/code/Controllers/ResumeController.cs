using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class ResumeController : Controller
    {
        public ResumeController(Board board, State state) : base(board, state) { }

        public void Reset()
        {
            this.Board.Reset();
            this.State.Reset();
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
