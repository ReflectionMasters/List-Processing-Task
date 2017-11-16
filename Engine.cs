namespace ListProcessing
{
    using System;
    using Interfaces;

    public class Engine
    {
        private const string EndCommand = "END";

        private ICommandInterpreter Interpreter;

        public Engine(ICommandInterpreter interpreter)
        {
            this.Interpreter = interpreter;
        }

        public void Run()
        {
            string commandInput = string.Empty;

            while ((commandInput = ConsoleManager.Read()) != EndCommand)
            {
                try
                {
                    var commandTokens = commandInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var command = commandTokens[0];

                    var element = string.Empty;
                    int index = -1;

                    if (commandTokens.Length == 3 
                        && command != "insert"
                        && command != "delete")
                    {
                        command = string.Empty;
                        element = commandInput;
                    }

                    if (int.TryParse(commandTokens[1], out index))
                    {
                        element = commandTokens[2];
                    }
                    else if(commandTokens.Length == 2)
                    {
                        element = commandTokens[1];
                    }

                    this.Interpreter.InterpretCommand(command, element, index).Execute();
                }
                catch (ArgumentException ex)
                {
                    ConsoleManager.WriteLine(ex.Message);
                }
            }
        }
    }
}
