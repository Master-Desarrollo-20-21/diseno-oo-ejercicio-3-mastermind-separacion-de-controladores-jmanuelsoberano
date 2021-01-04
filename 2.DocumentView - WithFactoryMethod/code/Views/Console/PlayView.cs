using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Models;

namespace MasterMind.Views.Console
{
    public class PlayView : WithBoardView
    {
        private BoardView _boardView;

        public PlayView(Board board) : base(board)
        {
            this._boardView = new BoardView(board);
        }

        public void Interact()
        {
            do
            {
                ProposedCombination proposedCombination = new ProposedCombination();
                ProposedCombinationView proposedCombinationView = new ProposedCombinationView(proposedCombination);
                proposedCombinationView.Read();
                this.Board.AddProposedCombination(proposedCombination);
                this._boardView.Write();
            } while (!this.Board.IsFinished());
        }
    }
}
