using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class ResumeController : Controller, AcceptorController
    {
        public ResumeController(Session session) : base(session)
        {
        }

        public void Reset()
        {
            this.session.Reset();
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