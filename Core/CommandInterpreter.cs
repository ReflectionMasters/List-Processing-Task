namespace ListProcessing
{
    using System;
    using System.Globalization;
    using ListProcessing.Interfaces;
    using System.Reflection;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandSuffix = "Command";
        private IListRepossitory listRepository;

        public CommandInterpreter(IListRepossitory listRepository)
        {
            this.listRepository = listRepository;
        }

        public IExecutable InterpretCommand(string command, string element)
        {
            var commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command) + commandSuffix;

            if (commandCompleteName == commandSuffix)
            {
                commandCompleteName = "InitialCommand";
            }

            Type commandType = Assembly
                              .GetExecutingAssembly()
                              .GetTypes()
                              .FirstOrDefault(t => t.Name == commandCompleteName);

            object[] commandParams =
            {
                element,
                this.listRepository
            };

            if (commandType == null)
            {
                throw new InvalidOperationException(Exceptions.InvalidCommandException);
            }

            return (IExecutable)Activator.CreateInstance(commandType, commandParams);
        }
    }
}
