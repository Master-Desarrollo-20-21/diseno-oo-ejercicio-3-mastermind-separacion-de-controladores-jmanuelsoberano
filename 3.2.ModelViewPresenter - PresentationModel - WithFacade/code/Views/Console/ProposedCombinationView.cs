using MasterMind.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using MasterMind.Controllers;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class ProposedCombinationView : WithLogicView
    {
        public ProposedCombinationView(Logic logic) : base(logic) {}

        public void Write(int position)
        {
            foreach (Color color in this._logic.GetColorsProposedCombination(position))
            {
                Consola.GetInstance().Write(color.ToString());
            }
        }

        public List<Color> Read()
        {
            Error error;
            List<Color> colors = new List<Color>();
            do
            {
                String combination = Consola.GetInstance().ReadString(Message.PROPOSED_COMBINATION.ToString());
                error = this._logic.CheckError(combination);
                Consola.GetInstance().WriteLine(error.ToString());
                if (error.IsNull())
                {
                    colors.AddRange(combination.Select(Color.GetInstance));
                }
            } while (!error.IsNull());
            
            return colors; 
        }

    }
}