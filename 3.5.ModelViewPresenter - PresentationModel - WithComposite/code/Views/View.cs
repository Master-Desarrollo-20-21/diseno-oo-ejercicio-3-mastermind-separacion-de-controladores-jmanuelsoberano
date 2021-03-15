using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class View : ControllersVisitor
    {
        public void Interact(Logic logic)
        {
            AcceptorController acceptorController;
            do
            {
                acceptorController = logic.GetController();
                if (!acceptorController.IsNull())
                {
                    acceptorController.Accept(this);
                }
            } while (!acceptorController.IsNull());
        }

        public abstract void visit(StartController startController);
        public abstract void visit(PlayController playController);
        public abstract void visit(ResumeController resumeController);
        public abstract void visit(NullController nullController);
    }
}