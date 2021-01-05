using MasterMind.Models;

namespace MasterMind.Views.Graphics
{
    public class GraphicsView : View
    {
        public GraphicsView(Board board) : base(board) {}

        protected override void Start() {}

        protected override void Play() {}

        protected override bool IsResume()
        {
            return false;
        }
    }
}
