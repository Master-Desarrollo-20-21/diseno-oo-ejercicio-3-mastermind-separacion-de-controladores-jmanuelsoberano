using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class StartController : Controller
    {
        public StartController(Board board) : base(board) { }
    }
}
