namespace ListProcessing.Commands
{
    using Interfaces;

    public class SortCommand : Command
    {
        public SortCommand(string[] paramStrings, IListRepossitory listRepossitory) 
            : base(paramStrings, listRepossitory)
        {
        }

        public override void Execute()
        {
            this.ValidateParams();
            this.ListRepossitory.Sort();
            this.ListRepossitory.PrintWorkingList();
        }
    }
}