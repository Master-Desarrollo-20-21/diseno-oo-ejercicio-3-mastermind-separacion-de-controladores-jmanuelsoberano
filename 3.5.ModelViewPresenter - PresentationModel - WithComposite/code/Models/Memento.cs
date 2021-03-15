using System.Collections.Generic;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class Memento
    {
        private List<string> proposedCombinationsStrings;

        public Memento(List<ProposedCombination> proposedCombinations)
        {
            this.proposedCombinationsStrings = new List<string>();
            foreach (ProposedCombination proposedCombination in proposedCombinations)
            {
                this.proposedCombinationsStrings.Add(proposedCombination.ToString());
            }
        }

        public List<ProposedCombination> GetProposedCombinations()
        {
            List<ProposedCombination> proposedCombinations = new List<ProposedCombination>();
            foreach (string proposedCombinationsString in this.proposedCombinationsStrings)
            {
                proposedCombinations.Add(new ProposedCombination(Color.Get(proposedCombinationsString)));
            }
            return proposedCombinations;
        }

        public List<Result> GetResults(SecretCombination secretCombination)
        {
            List<Result> results = new List<Result>();
            List<ProposedCombination> proposedCombinations = this.GetProposedCombinations();
            foreach (ProposedCombination proposedCombination in proposedCombinations)
            {
                results.Add(secretCombination.GetResult(proposedCombination));
            }
            return results;
        }

        public int GetAttempts()
        {
            return this.proposedCombinationsStrings.Count;
            //for (int i = 0; i < Board.MAX_ATTEMPTS; i++)
            //{
            //    if (this.proposedCombinationsStrings[i] == null) return i;
            //}
            //return Board.MAX_ATTEMPTS;
        }

    }

}