using System;

namespace MasterMind.Types
{
    public class Error
    {
        public static readonly Error DUPLICATED = new Error("Repeated colors");
        public static readonly Error WRONG_CHARACTERS = new Error("Wrong colors, they must be: " + Color.GetInitials());
        public static readonly Error WRONG_LENGTH = new Error("Wrong proposed combination length");
        public static readonly Error NULL = new Error("");

        private String message;

        private Error(String message)
        {
            this.message = message;
        }

        public Boolean IsNull()
        {
            return this == Error.NULL;
        }

        public override String ToString()
        {
            return this.message;
        }
    }
}