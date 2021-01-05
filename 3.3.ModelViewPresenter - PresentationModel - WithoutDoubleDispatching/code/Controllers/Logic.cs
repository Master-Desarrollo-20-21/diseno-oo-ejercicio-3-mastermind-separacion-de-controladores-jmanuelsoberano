using MasterMind.Types;
using System.Collections.Generic;
using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class Logic
    {
        private Board board;
        private StartController startController;
        private PlayController playController;
        private ResumeController resumeController;

        public Logic()
        {
            this.board = new Board();
            this.startController = new StartController(this.board);
            this.playController = new PlayController(this.board);
            this.resumeController = new ResumeController(this.board);
        }
        
        public int GetWidth()
        {
            return this.startController.GetWidth();
        }

        public int GetAttemps()
        {
            return this.playController.GetAttemps();
        }

        public bool IsWinner()
        {
            return this.playController.IsWinner();
        }

        public int GetWhitesResult(int position)
        {
            return this.playController.GetWhitesResult(position);
        }

        public void Reset()
        {
            this.resumeController.Reset();
        }

        public void AddProposedCombination(List<Color> combination)
        {
            this.playController.AddProposedCombination(combination);
        }

        public bool IsFinished()
        {
            return this.playController.IsFinished();
        }

        public int GetBlacksResult(int position)
        {
            return this.playController.GetBlacksResult(position);
        }

        public List<Color> GetColorsProposedCombination(int position)
        {
            return this.playController.GetColorsProposedCombination(position);
        }

        public bool IsLooser()
        {
            return this.playController.IsLooser();
        }

        public Error CheckError(string combination)
        {
            return this.playController.CheckError(combination);
        }
    }
}
