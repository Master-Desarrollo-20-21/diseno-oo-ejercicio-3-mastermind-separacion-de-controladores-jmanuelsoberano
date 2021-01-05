using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MasterMind.Models
{
    public class Board
    {
        private static readonly int MAX_ATTEMPTS = 10;
        private SecretCombination secretCombination;
        private List<ProposedCombination> proposedCombinations;
        private List<Result> results;
        private int attempts;

        public Board()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.secretCombination = new SecretCombination();
            this.proposedCombinations = new List<ProposedCombination>();
            this.results = new List<Result>();
            this.attempts = 0;
        }

        public void AddProposedCombination(ProposedCombination proposedCombination)
        {
            this.proposedCombinations.Add(proposedCombination);
            this.results.Add(this.secretCombination.GetResult(proposedCombination));
            this.attempts++;
        }

        public bool IsWinner()
        {
            Debug.Assert(this.attempts >= 1);
            return this.results[this.attempts - 1].IsWinner();
        }

        public bool IsLooser()
        {
            return this.attempts == Board.MAX_ATTEMPTS;
        }

        public Boolean IsFinished()
        {
            return this.IsWinner() || this.IsLooser();
        }

        public int GetAttemps()
        {
            return this.attempts;
        }

        public Result GetResult(int position)
        {
            Debug.Assert(position < this.results.Count);

            return this.results[position];
        }

        public ProposedCombination GetProposedCombination(int position)
        {
            Debug.Assert(position < this.proposedCombinations.Count);

            return this.proposedCombinations[position];
        }

    }
}
