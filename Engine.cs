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

        public void Listen()
        {
            string commandInput = ConsoleManager.Read();

            while (commandInput != EndCommand)
            {
                try
                {
                    this.ParseCommand(commandInput);
                }
                catch (ArgumentException ex)
                {
                    ConsoleManager.WriteLine(ex.Message);
                }

                commandInput = ConsoleManager.Read();
            }
        }

        private void ParseCommand(string commandInput)
        {
            var commandTokens = commandInput.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var command = commandTokens[0];

            var element = string.Empty;
            int index = -1;

            // switch is without reverse / delete / sоrt 
            // as we do not need parameters

            switch (command)
            {
                case "append":
                case "prepend":
                case "roll":
                    element = commandTokens[1];
                    break;
                case "insert":
                    index = int.Parse(commandTokens[1]);
                    element = commandTokens[2];
                    break;
                case "count":
                    element = commandTokens[1];
                    break;
                case "delete":
                    index = int.Parse(commandTokens[1]);
                    break;
                case "reverse":
                case "sort":
                    break;
                case "end":
                    ConsoleManager.WriteLine("Finished");
                    Environment.Exit(0);
                    break;
                default:
                    command = string.Empty;
                    element = commandInput;
                    break;
            }

            this.Interpreter.InterpretCommand(command, element, index).Execute();
        }
    }
}
