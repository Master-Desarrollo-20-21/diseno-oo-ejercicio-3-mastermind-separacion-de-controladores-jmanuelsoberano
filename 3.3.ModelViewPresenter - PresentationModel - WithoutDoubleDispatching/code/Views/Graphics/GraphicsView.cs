using MasterMind.Controllers;

namespace MasterMind.Views.Graphics
{
    public class GraphicsView : View
    {
        public GraphicsView(Logic logic) : base(logic) {}

        protected override void Start() {}

        protected override void Play() {}

        protected override bool IsResume()
        {
            return false;
        }
    }
}
