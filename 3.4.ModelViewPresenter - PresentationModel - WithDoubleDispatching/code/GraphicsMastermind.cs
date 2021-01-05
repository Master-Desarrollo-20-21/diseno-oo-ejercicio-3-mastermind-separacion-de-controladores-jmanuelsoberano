using MasterMind.Views;
using MasterMind.Views.Graphics;

namespace MasterMind
{
    public class GraphicsMastermind : MasterMind
    {
        protected override View CreateView()
        {
            return new GraphicsView();
        }
    }
}
