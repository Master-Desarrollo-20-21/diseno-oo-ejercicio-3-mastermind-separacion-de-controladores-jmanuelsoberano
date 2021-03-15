using MasterMind.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Models
{
    public class Session
    {
        private State state;
        private Board board;
        private Registry registry;

        public Session()
        {
            this.state = new State();
            this.board = new Board();
            this.registry = new Registry(this.board);
        }

        public void Reset()
        {
            this.board.Reset();
            this.state.Reset();
            this.registry.Reset();
        }

        public void NextState()
        {
            this.state.Next();
        }

        public bool IsUndoable()
        {
            return this.registry.IsUndoable();
        }

        public bool IsRedoable()
        {
            return this.registry.IsRedoable();
        }

        public void Undo()
        {
            this.registry.Undo();
        }

        public void Redo()
        {
            this.registry.Redo();
        }

        public void AddProposedCombination(List<Color> colors)
        {
            this.board.AddProposedCombination(colors);
            this.registry.Register();
        }

        public int GetBlacks(int position)
        {
            return this.board.GetBlacks(position);
        }

        public int GetWhites(int position)
        {
            return this.board.GetWhites(position);
        }

        public List<Color> GetProposedCombinationColors(int position)
        {
            return this.board.GetProposedCombinationColors(position);
        }

        public Error GetError(List<Color> colors)
        {
            return this.board.GetError(colors);
        }

        public int GetAttempts()
        {
            return this.board.GetAttempts();
        }

        public bool IsFinished()
        {
            return this.board.IsFinished();
        }

        public bool IsWinner()
        {
            return this.board.IsWinner();
        }

        public bool IsLooser()
        {
            return this.board.IsLooser();
        }

        public StateValue GetValueState()
        {
            return this.state.GetValueState();
        }

	}
}
