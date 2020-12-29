using System;
using System.Diagnostics;

namespace MasterMind
{
    public class YesNoDialog
    {
        private const char Affirmative = 'y';
        private const char Negative = 'n';

        private static readonly string Suffix = "? (" +
                                                Affirmative + "/" +
                                                Negative + "): ";
        private static readonly string Message = "The value must be '" + 
                                                 Affirmative + "' or '" + 
                                                 Negative + "'";

        private char _answer;

        public Boolean Read(String message)
        {
            Debug.Assert(message != null);

            Consola console = Consola.GetInstance();
            Boolean error;
            do
            {
                console.Write(message);
                this._answer = console.ReadChar(YesNoDialog.Suffix);
                error = !this.IsAfirmative() && !this.IsNegative();
                if (error)
                {
                    console.WriteLine(YesNoDialog.Message);
                }
            } while (error);
            return this.IsAfirmative();
        }

        private Boolean IsAfirmative()
        {
            return this.GetAnswer() == YesNoDialog.Affirmative;
        }

        private char GetAnswer()
        {
            return char.ToLower(this._answer);
        }

        private Boolean IsNegative()
        {
            return char.ToLower(this._answer) == YesNoDialog.Negative;
        }
	}
}
