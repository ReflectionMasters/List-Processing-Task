namespace ListProcessing.Interfaces
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string command, string element);
    }
}
