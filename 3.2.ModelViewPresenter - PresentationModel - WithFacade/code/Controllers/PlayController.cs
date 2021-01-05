using MasterMind.Models;
using MasterMind.Types;
using System.Collections.Generic;

namespace MasterMind.Controllers
{
    public class PlayController : Controller
    {
        public PlayController(Board board) : base(board) {}

        public void AddProposedCombination(List<Color> combination)
        {
            ProposedCombination proposedCombination = new ProposedCombination();
            proposedCombination.GetColors().AddRange(combination);
            this.Board.AddProposedCombination(proposedCombination);
        }

        public int GetBlacksResult(int position)
        {
            return this.Board.GetResult(position).GetBlacks();
        }

        public int GetWhitesResult(int position)
        {
            return this.Board.GetResult(position).GetWhites();
        }

        public List<Color> GetColorsProposedCombination(int position)
        {
            return this.Board.GetProposedCombination(position).GetColors();
        }

        public int GetAttemps()
        {
            return this.Board.GetAttemps();
        }

        public bool IsFinished()
        {
            return this.Board.IsFinished();
        }

        public Error CheckError(string combination)
        {
            if (combination.Length != Combination.GetWidth())
            {
                return Error.WRONG_LENGTH;
            }

            List<Color> colors = new List<Color>();
            for (int i = 0; i < combination.Length; i++)
            {
                Color color = Color.GetInstance(combination[i]);
                if (color.IsNull())
                {
                    return Error.WRONG_CHARACTERS;
                }
                for (int j = 0; j < i; j++)
                {
                    if (colors[j] == color)
                    {
                        return Error.DUPLICATED;
                    }
                }
                colors.Add(color);
            }
            return Error.NULL;
        }

        public bool IsLooser()
        {
            return this.Board.IsLooser();
        }

        public bool IsWinner()
        {
            return this.Board.IsWinner();
        }
    }
}
