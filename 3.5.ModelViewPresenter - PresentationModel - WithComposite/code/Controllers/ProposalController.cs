using System.Collections.Generic;
using MasterMind.Models;
using MasterMind.Types;

namespace MasterMind.Controllers
{
    public class ProposalController : Controller
    {
        public ProposalController(Session session) : base(session)
        {
        }

        public Error GetError(List<Color> colors)
        {
            return this.session.GetError(colors);
        }

        public void Add(List<Color> colors)
        {
            this.session.AddProposedCombination(colors);
        }

        public bool IsFinished()
        {
            return this.session.IsFinished();
        }

        public bool IsWinner()
        {
            return this.session.IsWinner();
        }

        public bool IsLooser()
        {
            return this.session.IsLooser();
        }

        public bool IsNull()
        {
            return false;
        }

        public int GetBlacks(int position)
        {
            return this.session.GetBlacks(position);
        }

        public int GetWhites(int position)
        {
            return this.session.GetWhites(position);
        }

        public List<Color> GetProposedCombinationColors(int position)
        {
            return this.session.GetProposedCombinationColors(position);
        }
    }
}
