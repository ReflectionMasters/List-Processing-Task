namespace ListProcessing.Commands
{
    using Interfaces;

    public class SortCommand : Command
    {
        public SortCommand(string element, IListRepossitory listRepossitory, int index) 
            : base(element, listRepossitory, index)
        {
        }

        public override void Execute()
        {
            this.ListRepossitory.Sort();
            this.ListRepossitory.PrintWorkingList();
        }
    }
}