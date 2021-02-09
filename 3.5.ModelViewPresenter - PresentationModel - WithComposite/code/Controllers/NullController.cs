using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class NullController : Controller
    {
        public NullController(Board board, State state) : base(board, state)
        {
        }

        public override bool IsNull()
        {
            return true;
        }

        public override void accept(ControllersVisitor controllersVisitor)
        {
            controllersVisitor.visit(this);
        }
    }
}