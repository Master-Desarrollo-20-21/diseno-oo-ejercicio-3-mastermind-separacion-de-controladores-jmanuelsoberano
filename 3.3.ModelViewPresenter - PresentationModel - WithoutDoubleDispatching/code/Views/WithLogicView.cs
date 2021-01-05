using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class WithLogicView
    {
        protected Logic logic;

        public WithLogicView(Logic logic)
        {
            this.logic = logic;
        }
    }
}
