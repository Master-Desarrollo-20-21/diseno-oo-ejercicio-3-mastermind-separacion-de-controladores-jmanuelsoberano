using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class StartController : Controller, AcceptorController
    {
        public StartController(Session session) : base(session)
        {
        }

        public bool IsNull()
        {
            return false;
        }

        public void Accept(ControllersVisitor controllersVisitor)
        {
            controllersVisitor.visit(this);
        }
    }
}