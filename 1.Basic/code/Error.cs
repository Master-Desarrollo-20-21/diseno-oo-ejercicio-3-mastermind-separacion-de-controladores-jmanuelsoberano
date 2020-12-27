using System;

namespace MasterMind
{
    public class Error
    {
        public static readonly Error Duplicated = new Error("Repeated colors");
        public static readonly Error WrongCharacters = new Error("Wrong colors, they must be: " + Color.GetInitials());
        public static readonly Error WrongLength = new Error("Wrong proposed combination length");
        public static readonly Error NullError = new Error("");

        private String message;

        Error(String message)
        {
            this.message = message;
        }

        public void WriteLine()
        {
            if (!this.IsNull())
            {
                Consola.GetInstance().WriteLine(this.message);
            }
        }

        public Boolean IsNull()
        {
            return this == Error.NullError;
        }

    }
}
