using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class StartController : Controller
    {
        public StartController(Board board, State state) : base(board, state)
        {
        }

        public override bool IsNull()
        {
            return false;
        }

        public override void accept(ControllersVisitor controllersVisitor)
        {
            controllersVisitor.visit(this);
        }
    }

}
