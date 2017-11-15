namespace ListProcessing.Commands
{
    using ListProcessing.Interfaces;

    public class AppendCommand : Command
    {
        public AppendCommand(string element, IListRepossitory listRepository) 
            : base (element, listRepository)
        {

        }
        public override void Execute()
        {
            this.ListRepossitory.Prepend(this.Element);
            this.ListRepossitory.PrintWorkingList();
        }
    }
}
