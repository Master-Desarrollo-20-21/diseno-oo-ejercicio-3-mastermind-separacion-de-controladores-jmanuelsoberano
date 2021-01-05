using MasterMind.Types;
using System.Collections.Generic;
using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class Logic
    {
        private Board _board;
        private StartController _startController;
        private PlayController _playController;
        private ResumeController _resumeController;

        public Logic()
        {
            this._board = new Board();
            this._startController = new StartController(this._board);
            this._playController = new PlayController(this._board);
            this._resumeController = new ResumeController(this._board);
        }
        
        public int GetWidth()
        {
            return this._startController.GetWidth();
        }

        public int GetAttemps()
        {
            return this._playController.GetAttemps();
        }

        public bool IsWinner()
        {
            return this._playController.IsWinner();
        }

        public int GetWhitesResult(int position)
        {
            return this._playController.GetWhitesResult(position);
        }

        public void Reset()
        {
            this._resumeController.Reset();
        }

        public void AddProposedCombination(List<Color> combination)
        {
            this._playController.AddProposedCombination(combination);
        }

        public bool IsFinished()
        {
            return this._playController.IsFinished();
        }

        public int GetBlacksResult(int position)
        {
            return this._playController.GetBlacksResult(position);
        }

        public List<Color> GetColorsProposedCombination(int position)
        {
            return this._playController.GetColorsProposedCombination(position);
        }

        public bool IsLooser()
        {
            return this._playController.IsLooser();
        }

        public Error CheckError(string combination)
        {
            return this._playController.CheckError(combination);
        }
    }
}
