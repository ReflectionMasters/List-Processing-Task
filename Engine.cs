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
                    var element = commandTokens[1];

                    if (commandTokens.Length == 3)
                    {
                        command = string.Empty;
                        element = commandInput;
                    }

                    this.Interpreter.InterpretCommand(command, element).Execute();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
