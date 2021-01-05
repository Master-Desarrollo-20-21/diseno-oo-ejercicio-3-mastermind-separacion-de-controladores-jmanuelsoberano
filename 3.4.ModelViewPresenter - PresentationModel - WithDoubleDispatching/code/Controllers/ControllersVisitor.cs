using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Controllers
{
    public interface ControllersVisitor
    {
        public void visit(StartController startController);

        public void visit(PlayController playController);

        public void visit(ResumeController resumeController);

        public void visit(NullController nullController);
    }
}
