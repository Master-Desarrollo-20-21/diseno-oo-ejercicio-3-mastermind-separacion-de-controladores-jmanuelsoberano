using MasterMind.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using MasterMind.Controllers;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class ProposedCombinationView
    {
        private PlayController playController;

        public ProposedCombinationView(PlayController playController)
        {
            this.playController = playController;
        }

        public void Write(int position)
        {
            foreach (Color color in this.playController.GetColorsProposedCombination(position))
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
                error = this.playController.CheckError(combination);
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