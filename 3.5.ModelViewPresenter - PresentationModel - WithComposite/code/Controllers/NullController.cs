using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class NullController : Controller, AcceptorController
    {
        public NullController(Session session) : base(session)
        {
        }

        public bool IsNull()
        {
            return true;
        }

        public void Accept(ControllersVisitor controllersVisitor)
        {
            controllersVisitor.visit(this);
        }
    }
}