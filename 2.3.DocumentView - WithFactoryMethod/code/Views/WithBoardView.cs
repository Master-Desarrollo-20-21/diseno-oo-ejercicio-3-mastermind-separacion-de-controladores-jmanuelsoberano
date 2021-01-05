using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Models;

namespace MasterMind.Views
{
    public abstract class WithBoardView
    {
        protected Board Board;

        protected WithBoardView(Board board)
        {
            this.Board = board;
        }
    }
}
