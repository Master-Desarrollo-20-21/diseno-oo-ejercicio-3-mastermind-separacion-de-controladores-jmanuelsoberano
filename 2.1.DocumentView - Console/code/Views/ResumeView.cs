using System;
using MasterMind.Models;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views
{
    public class ResumeView : WithBoardView
    {
        public ResumeView(Board game) : base(game) {}

        public Boolean Interact()
        {
            Boolean isResumed = new YesNoDialog().Read(Message.RESUME.ToString());
            if (isResumed)
            {
                this.Board.Reset();
            }
            return isResumed;
        }
    }
}
