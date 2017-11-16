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

                    // без reverse / delete / sоrt 
                    //case защото не ни трябват параметри

                    switch (command)
                    {
                        case "append":
                            element = commandTokens[1];
                            break;
                        case "prepend":
                            element = commandTokens[1];
                            break;
                        case "insert":
                            index = int.Parse(commandTokens[1]);
                            element = commandTokens[2];
                            break;
                        case "roll":
                            throw new NotImplementedException();
                            break;
                        case "count":
                            throw new NotImplementedException();
                            break;

                        case "reverse":
                        case "delete":
                        case "sort":
                            break;
                        case "end":
                            throw new NotImplementedException();
                            break;
                        default:
                            command = string.Empty;
                            element = commandInput;
                            break;
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
