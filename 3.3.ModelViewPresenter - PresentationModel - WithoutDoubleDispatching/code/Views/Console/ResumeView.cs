using System;
using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResumeView : WithLogicView
    {
        public ResumeView(Logic logic) : base(logic) {}

        public Boolean Interact()
        {
            Boolean isResumed = new YesNoDialog().Read(Message.RESUME.ToString());
            if (isResumed)
            {
                this.logic.Reset();
            }
            return isResumed;
        }
    }
}
