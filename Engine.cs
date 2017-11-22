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

            try
            {
                this.Interpreter.InterpretCommand(commandTokens).Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
