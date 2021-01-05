using MasterMind.Controllers;
using MasterMind.Views;
using MasterMind.Views.Graphics;

namespace MasterMind
{
    public class GraphicsMastermind : MasterMind
    {
        protected override View CreateView(StartController startController, PlayController playController, ResumeController resumeController)
        {
            return new GraphicsView(startController, playController, resumeController);
        }
    }
}
