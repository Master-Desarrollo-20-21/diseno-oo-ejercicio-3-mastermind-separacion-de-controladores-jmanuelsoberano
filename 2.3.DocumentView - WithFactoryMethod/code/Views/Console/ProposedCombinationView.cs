using MasterMind.Models;
using MasterMind.Utils;
using System;
using System.Linq;
using MasterMind.Types;

namespace MasterMind.Views.Console
{
    public class ProposedCombinationView
    {
        private ProposedCombination proposedCombination;

        public ProposedCombinationView(ProposedCombination proposedCombination)
        {
            this.proposedCombination = proposedCombination;
        }

        public void Write()
        {
            foreach (Color color in this.proposedCombination.GetColors())
            {
                Consola.GetInstance().Write(color.ToString());
            }
        }

        public void Read()
        {
            Error error;
            do
            {
                String combination = Consola.GetInstance().ReadString(Message.PROPOSED_COMBINATION.ToString());
                error = this.proposedCombination.CheckError(combination);
                Consola.GetInstance().WriteLine(error.ToString());
                if (error.IsNull())
                {
                    this.proposedCombination.GetColors().AddRange(combination.Select(Color.GetInstance));
                }
            } while (!error.IsNull());
        }

    }
}