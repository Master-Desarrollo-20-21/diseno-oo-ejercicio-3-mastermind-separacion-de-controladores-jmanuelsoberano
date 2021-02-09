using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Controllers
{
    public interface ControllersVisitor
    {
        void visit(StartController startController);

        void visit(PlayController playController);

        void visit(ResumeController resumeController);

        void visit(NullController nullController);
    }
}