using System;
using MasterMind.Controllers;
using MasterMind.Types;
using MasterMind.Utils;

namespace MasterMind.Views.Console
{
    public class ResumeView
    {
        public void Interact(ResumeController resumeController)
        {
            Boolean isResumed = new YesNoDialog().Read(Message.RESUME.ToString());
            if (isResumed)
            {
                resumeController.Reset();
            }
            else
            {
                resumeController.NextState();
            }
        }
    }
}