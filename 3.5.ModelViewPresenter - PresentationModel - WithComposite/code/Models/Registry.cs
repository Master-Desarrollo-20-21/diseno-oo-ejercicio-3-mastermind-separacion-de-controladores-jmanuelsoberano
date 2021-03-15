using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MasterMind.Models
{
    public class Registry
    {
        private List<Memento> mementos;
        private Board board;
        private int firstPrevious;

        public Registry(Board board)
        {
            this.board = board;
            this.Reset();
        }

        public void Reset()
        {
            this.firstPrevious = 0;
            this.mementos = new List<Memento>();
            this.mementos.Insert(this.firstPrevious, this.board.CreateMemento());
        }

        public void Register()
        {
            for (int i = 0; i < this.firstPrevious; i++)
            {
                this.mementos.RemoveAt(0);
            }
            this.firstPrevious = 0;
            this.mementos.Insert(this.firstPrevious, this.board.CreateMemento());
        }

        public void Undo()
        {
            Debug.Assert(this.IsUndoable());
            this.firstPrevious++;
            this.board.SetMemento(this.mementos[this.firstPrevious]);
        }

        public void Redo()
        {
            Debug.Assert(this.IsRedoable());
            this.firstPrevious--;
            this.board.SetMemento(this.mementos[this.firstPrevious]);
        }

        public bool IsUndoable()
        {
            return this.firstPrevious < this.mementos.Count - 1;
        }

        public bool IsRedoable()
        {
            return this.firstPrevious >= 1;
        }

    }
}
