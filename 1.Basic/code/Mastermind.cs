namespace MasterMind
{
    class Mastermind
    {
        private Board _board;

        public void Play()
        {
            do
            {
                this.PlayGame();
            } while (this.IsResume());
        }

        private void PlayGame()
        {
            this.Init();

            do
            {
                ProposedCombination proposedCombination = new ProposedCombination();
                proposedCombination.Read();
                this._board.Add(proposedCombination);
                this._board.WriteLine();
            } while (!this._board.IsFinished());

            this.Finish();
        }

        private void Init()
        {
            Message.Title.WriteLine();
            this._board = new Board();
            this._board.WriteLine();
        }

        private void Finish()
        {
            Message message = Message.Looser;
            if (this._board.IsWinner())
            {
                message = Message.Winner;
            }
            message.WriteLine();
        }

        private bool IsResume()
        {
            return new YesNoDialog().Read(Message.Resume.ToString());
        }
    }
}
