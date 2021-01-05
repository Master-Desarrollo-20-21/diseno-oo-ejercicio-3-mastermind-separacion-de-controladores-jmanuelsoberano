using System;


namespace MasterMind
{
    public class Consola
    {
        private static readonly Consola Console = new Consola();

        public static Consola GetInstance()
        {
            return Console;
        }

        public String ReadString(String title)
        {
            String input = null;
            this.Write(title);
            try
            {
                input = System.Console.ReadLine();
            }
            catch (Exception)
            {
                // ignored
            }

            return input;
        }

        public String ReadString()
        {
            return this.ReadString("");
        }

        public int ReadInt(String title)
        {
            int input = 0;
            Boolean ok = false;
            do
            {
                try
                {
                    input = Convert.ToInt32(this.ReadString(title));
                    ok = true;
                }
                catch (Exception)
                {
                }
            } while (!ok);
            return input;
        }

        public char ReadChar(String title)
        {
            char charValue = ' ';
            Boolean ok = false;
            do
            {
                String input = this.ReadString(title);
                if (input.Length != 1)
                {
                }
                else
                {
                    charValue = input[0];
                    ok = true;
                }
            } while (!ok);
            return charValue;
        }

        public void WriteLine()
        {
            System.Console.WriteLine();
        }

        public void Write(String cadena)
        {
            System.Console.Write(cadena);
        }

        public void WriteLine(String cadena)
        {
            System.Console.WriteLine(cadena);
        }

        public void Write(char character)
        {
            System.Console.Write(character);
        }

    }

}
