namespace ListProcessing
{
    using System;
    using System.Globalization;
    using Interfaces;
    using System.Reflection;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandSuffix = "Command";
        private const string InitialCommandName = "Initial";
        private IListRepossitory listRepository;
        private bool isFirstRun;

        public CommandInterpreter(IListRepossitory listRepository)
        {
            this.listRepository = listRepository;
            this.isFirstRun = true;
        }

        public IExecutable InterpretCommand(string[] commandTokens)
        {
            string command;

            if (this.isFirstRun)
            {
                command = InitialCommandName;
                this.isFirstRun = false;
            }
            else
            {
                command = commandTokens[0];
                commandTokens = commandTokens.Skip(1).ToArray();
            }

            string commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command) + commandSuffix;


            Type commandType = Assembly
                              .GetExecutingAssembly()
                              .GetTypes()
                              .FirstOrDefault(t => t.Name == commandCompleteName);

            object[] commandParams =
            {
                commandTokens,
                this.listRepository
            };

            if (commandType == null)
            {
                throw new InvalidOperationException(Exceptions.InvalidCommandException);
            }

            IExecutable commandInstance = (IExecutable)Activator.CreateInstance(commandType, commandParams);

            return commandInstance;
        }
    }
}
