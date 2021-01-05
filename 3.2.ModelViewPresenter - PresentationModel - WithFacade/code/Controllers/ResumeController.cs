using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class ResumeController : Controller
    {
        public ResumeController(Board board) : base(board) { }

        public void Reset()
        {
            this.Board.Reset();
        }
    }
}
