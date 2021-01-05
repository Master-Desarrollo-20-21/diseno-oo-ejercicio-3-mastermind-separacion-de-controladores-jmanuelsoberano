using System;
using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResumeView
    {
        private ResumeController _resumeController;

        public ResumeView(ResumeController resumeController)
        {
            this._resumeController = resumeController;
        }

        public Boolean Interact()
        {
            Boolean isResumed = new YesNoDialog().Read(Message.RESUME.ToString());
            if (isResumed)
            {
                this._resumeController.Reset();
            }
            return isResumed;
        }
    }
}
