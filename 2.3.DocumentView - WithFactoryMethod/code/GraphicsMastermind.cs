using MasterMind.Models;
using MasterMind.Views;
using MasterMind.Views.Graphics;

namespace MasterMind
{
    public class GraphicsMastermind : MasterMind
    {
        protected override View CreateView(Board board)
        {
            return new GraphicsView(board);
        }
    }
}
