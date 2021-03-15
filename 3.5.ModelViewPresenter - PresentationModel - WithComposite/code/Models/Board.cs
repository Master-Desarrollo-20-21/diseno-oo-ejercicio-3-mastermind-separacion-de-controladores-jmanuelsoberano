using System;
using System.Collections.Generic;
using System.Diagnostics;
using MasterMind.Types;

namespace MasterMind.Models
{
    public class Board
    {
        public const int MAX_ATTEMPTS = 10;
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

        public void AddProposedCombination(List<Color> combination)
        {
            ProposedCombination proposedCombination = new ProposedCombination(combination);
            this.proposedCombinations.Add(proposedCombination);
            this.results.Add(this.GetResult(this.proposedCombinations[this.attempts]));
            this.attempts++;
        }

        public Memento CreateMemento()
        {
            return new Memento(this.proposedCombinations);
        }

        public void SetMemento(Memento memento)
        {
            this.attempts = memento.GetAttempts();
            this.proposedCombinations = memento.GetProposedCombinations();
            this.results = memento.GetResults(this.secretCombination);
        }

        public bool IsWinner()
        {
            if (this.attempts == 0)
            {
                return false;
            }
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

        public int GetAttempts()
        {
            return this.attempts;
        }

        public Result GetResult(ProposedCombination proposedCombination)
        {
            return this.secretCombination.GetResult(proposedCombination);
        }

        private Result GetResult(int position)
        {
            Debug.Assert(position < this.results.Count);

            return this.results[position];
        }

        public List<Color> GetProposedCombinationColors(int position)
        {
            Debug.Assert(position < this.proposedCombinations.Count);

            return this.proposedCombinations[position].GetColors();
        }

        public int GetBlacks(int position)
        {
            return this.GetResult(position).GetBlacks();
        }

        public int GetWhites(int position)
        {
            return this.GetResult(position).GetWhites();
        }

        public Error GetError(List<Color> colors)
        {
            return new ProposedCombination(colors).GetError();
        }

    }
}