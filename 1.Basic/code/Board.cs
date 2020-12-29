using System;

namespace MasterMind
{
    class Board
    {
        private const int MaxAttempts = 10;
        private SecretCombination _secretCombination;
        private ProposedCombination[] _proposedCombinations;
        private Result[] _results;
        private int _attempts;

        public Board()
        {
            this._secretCombination = new SecretCombination();
            this._proposedCombinations = new ProposedCombination[Board.MaxAttempts];
            this._results = new Result[Board.MaxAttempts];
            this._attempts = 0;
        }

        public void WriteLine()
        {
            Consola.GetInstance().WriteLine();
            Message.Attempts.WriteLine(this._attempts);
            this._secretCombination.WriteLine();
            for (int i = 0; i < this._attempts; i++)
            {
                this._proposedCombinations[i].Write();
                this._results[i].WriteLine();
            }
        }

        public void Add(ProposedCombination proposedCombination)
        {
            this._proposedCombinations[this._attempts] = proposedCombination;
            this._results[this._attempts] = this._secretCombination.GetResult(proposedCombination);
            this._attempts++;
        }

        public Boolean IsFinished()
        {
            return this.IsWinner() || this.IsLooser();
        }

        public Boolean IsWinner()
        {
            return this._results[this._attempts - 1].IsWinner();
        }

        private Boolean IsLooser()
        {
            return this._attempts == Board.MaxAttempts;
        }
    }
}
