using MasterMind.Models;
using MasterMind.Views.Graphics;

namespace MasterMind
{
    public class GraphicsMastermind
    {
        private readonly GraphicsView _graphicsView;

        public GraphicsMastermind()
        {
            this._graphicsView = new GraphicsView(new Board());
        }

        public void Play()
        {
            this._graphicsView.Interact();
        }
    }
}
