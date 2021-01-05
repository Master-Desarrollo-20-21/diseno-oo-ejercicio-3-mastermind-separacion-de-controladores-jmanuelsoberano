using MasterMind.Controllers;

namespace MasterMind.Views.Graphics
{
    public class GraphicsView : View
    {
        public GraphicsView(StartController startController, PlayController playController, ResumeController resumeController) : base(startController, playController, resumeController) {}

        protected override void Start() {}

        protected override void Play() {}

        protected override bool IsResume()
        {
            return false;
        }
    }
}
