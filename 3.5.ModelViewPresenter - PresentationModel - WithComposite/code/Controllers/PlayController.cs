using MasterMind.Models;
using MasterMind.Types;
using System.Collections.Generic;

namespace MasterMind.Controllers
{
    public class PlayController : Controller, AcceptorController
    {
        private ProposalController proposalController;
        private UndoController undoController;
        private RedoController redoController;

        public PlayController(Session session) : base(session)
        {
            this.proposalController = new ProposalController(this.session);
            this.undoController = new UndoController(this.session);
            this.redoController = new RedoController(this.session);
        }

        public Error GetError(List<Color> combination)
        {
            return this.proposalController.GetError(combination);
        }

        public void AddProposedCombination(List<Color> combination)
        {
            this.proposalController.Add(combination);
        }

        public int GetBlacksResult(int position)
        {
            return this.proposalController.GetBlacks(position);
        }

        public int GetWhitesResult(int position)
        {
            return this.proposalController.GetWhites(position);
        }

        public List<Color> GetProposedCombinationColors(int position)
        {
            return this.proposalController.GetProposedCombinationColors(position);
        }

        public int GetAttemps()
        {
            return this.proposalController.GetAttempts();
        }

        public bool IsFinished()
        {
            return this.proposalController.IsFinished();
        }

        public bool IsLooser()
        {
            return this.proposalController.IsLooser();
        }

        public bool IsWinner()
        {
            return this.proposalController.IsWinner();
        }

        public bool IsNull()
        {
            return false;
        }

        public void Accept(ControllersVisitor controllersVisitor)
        {
            controllersVisitor.visit(this);
        }

        public bool IsUndoable()
        {
            return this.undoController.IsUndoable();
        }

        public bool IsRedoable()
        {
            return this.redoController.IsRedoable();
        }

        public void Undo()
        {
            this.undoController.Undo();
        }

        public void Redo()
        {
            this.redoController.Redo();
        }
    }
}