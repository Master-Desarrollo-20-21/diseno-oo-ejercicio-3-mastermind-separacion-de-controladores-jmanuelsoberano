using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class View : ControllersVisitor
    {
        public void Interact(Controller controller)
        {
            controller.accept(this);
        }

        public abstract void visit(StartController startController);
        public abstract void visit(PlayController playController);
        public abstract void visit(ResumeController resumeController);

        public void visit(NullController nullController)
        {
        }
    }
}