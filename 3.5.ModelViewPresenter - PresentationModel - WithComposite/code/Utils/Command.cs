using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Utils
{
    public abstract class Command
    {
        protected string title;

        protected Command(string title)
        {
            this.title = title;
        }

        public abstract void execute();

        public abstract bool IsActive();

        public string GetTitle()
        {
            return this.title;
        }
    }
}
