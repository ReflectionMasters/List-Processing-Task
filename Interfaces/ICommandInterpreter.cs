namespace ListProcessing.Interfaces
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] commandTokens);
    }
}
