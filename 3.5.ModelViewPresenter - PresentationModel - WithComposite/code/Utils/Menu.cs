using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MasterMind.Utils
{
    public abstract class Menu
    {
        private static string OPTION = "----- Choose one option -----";

        private List<Command> commands;

        public Menu()
        {
            this.commands = new List<Command>();
        }

        public void execute()
        {
            List<Command> commands = new List<Command>();
            for (int i = 0; i < this.commands.Count; i++)
            {
                if (this.commands[i].IsActive())
                {
                    commands.Add(this.commands[i]);
                }
            }
            
            Debug.Assert(commands.Count > 0); //TODO ¿Menú sin comandos activos incluido en el dominio?

            bool error;
            int option;
            do
            {
                error = false;
                Consola.GetInstance().WriteLine();
                Consola.GetInstance().WriteLine(Menu.OPTION);
                for (int i = 0; i < commands.Count; i++)
                {
                    Consola.GetInstance().WriteLine((i + 1) + ") " + commands[i].GetTitle());
                }
                option = Consola.GetInstance().ReadInt("") - 1;
                if (!new ClosedInterval(0, commands.Count - 1).IsIncluded(option))
                {
                    error = true;
                }
            } while (error);
            commands[option].execute();
        }

        protected void AddCommand(Command command)
        {
            this.commands.Add(command);
        }
	}
}
