using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MasterMind.Models
{
    public class Board
    {
        private static readonly int MAX_ATTEMPTS = 10;
        private SecretCombination _secretCombination;
        private List<ProposedCombination> _proposedCombinations;
        private List<Result> _results;
        private int _attempts;

        public Board()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._secretCombination = new SecretCombination();
            this._proposedCombinations = new List<ProposedCombination>();
            this._results = new List<Result>();
            this._attempts = 0;
        }

        public void AddProposedCombination(ProposedCombination proposedCombination)
        {
            this._proposedCombinations.Add(proposedCombination);
            this._results.Add(this._secretCombination.GetResult(proposedCombination));
            this._attempts++;
        }

        public bool IsWinner()
        {
            Debug.Assert(this._attempts >= 1);
            return this._results[this._attempts - 1].IsWinner();
        }

        public bool IsLooser()
        {
            return this._attempts == Board.MAX_ATTEMPTS;
        }

        public Boolean IsFinished()
        {
            return this.IsWinner() || this.IsLooser();
        }

        public int GetAttemps()
        {
            return this._attempts;
        }

        public Result GetResult(int position)
        {
            Debug.Assert(position < this._results.Count);

            return this._results[position];
        }

        public ProposedCombination GetProposedCombination(int position)
        {
            Debug.Assert(position < this._proposedCombinations.Count);

            return this._proposedCombinations[position];
        }

    }
}
