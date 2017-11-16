namespace ListProcessing
{
    public class StartUp
    {
        public static void Main()
        {
            ListRepository repo = new ListRepository();
            CommandInterpreter interpreter = new CommandInterpreter(repo);
            Engine engine = new Engine(interpreter);

            engine.Run();
        }
    }
}
