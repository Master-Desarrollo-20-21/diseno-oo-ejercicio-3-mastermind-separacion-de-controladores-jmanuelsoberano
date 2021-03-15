using System.Collections.Generic;
using MasterMind.Models;
using MasterMind.Types;

namespace MasterMind.Controllers
{
    public abstract class Controller
    {
        protected Session session;

        public Controller(Session session)
        {
            this.session = session;
        }

        public void NextState()
        {
            this.session.NextState();
        }

        public int GetAttempts()
        {
            return this.session.GetAttempts();
        }

        public List<Color> GetProposedCombinationColors(int position)
        {
            return this.session.GetProposedCombinationColors(position);
        }

        public int GetWidth()
        {
            return Combination.GetWidth();
        }

    }
}