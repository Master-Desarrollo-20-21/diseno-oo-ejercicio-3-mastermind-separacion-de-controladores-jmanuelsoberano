using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class RedoController : Controller
    {
        public RedoController(Session session) : base(session)
        {
        }

        public void Redo()
        {
            this.session.Redo();
        }

        public bool IsRedoable()
        {
            return this.session.IsRedoable();
        }
    }
}
