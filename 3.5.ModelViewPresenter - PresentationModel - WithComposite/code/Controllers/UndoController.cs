using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Controllers
{
    public class UndoController : Controller
    {
        public UndoController(Session session) : base(session)
        {
        }

        public bool IsUndoable()
        {
            return this.session.IsUndoable();
        }

        public void Undo()
        {
            this.session.Undo();
        }
    }
}
