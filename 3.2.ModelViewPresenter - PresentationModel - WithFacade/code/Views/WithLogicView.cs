﻿using System;
using System.Collections.Generic;
using System.Text;
using MasterMind.Controllers;

namespace MasterMind.Views
{
    public abstract class WithLogicView
    {
        protected Logic _logic;

        public WithLogicView(Logic logic)
        {
            this._logic = logic;
        }
    }
}
