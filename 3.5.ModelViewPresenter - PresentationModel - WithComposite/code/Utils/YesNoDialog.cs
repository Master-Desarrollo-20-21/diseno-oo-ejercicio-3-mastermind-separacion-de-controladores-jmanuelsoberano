using System;
using System.Diagnostics;

namespace MasterMind.Utils
{
    public class YesNoDialog
    {
        private const char AFFIRMATIVE = 'y';
        private const char NEGATIVE = 'n';

        private static readonly string SUFFIX = "? (" +
                                                AFFIRMATIVE + "/" +
                                                NEGATIVE + "): ";

        private static readonly string MESSAGE = "The value must be '" +
                                                 AFFIRMATIVE + "' or '" +
                                                 NEGATIVE + "'";

        private char answer;

        public Boolean Read(String message)
        {
            Debug.Assert(message != null);

            Consola console = Consola.GetInstance();
            Boolean error;
            do
            {
                console.Write(message);
                this.answer = console.ReadChar(YesNoDialog.SUFFIX);
                error = !this.IsAfirmative() && !this.IsNegative();
                if (error)
                {
                    console.WriteLine(YesNoDialog.MESSAGE);
                }
            } while (error);

            return this.IsAfirmative();
        }

        private Boolean IsAfirmative()
        {
            return this.GetAnswer() == YesNoDialog.AFFIRMATIVE;
        }

        private char GetAnswer()
        {
            return char.ToLower(this.answer);
        }

        private Boolean IsNegative()
        {
            return char.ToLower(this.answer) == YesNoDialog.NEGATIVE;
        }
    }
}