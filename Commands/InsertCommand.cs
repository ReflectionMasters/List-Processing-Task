namespace ListProcessing.Commands
{
    using ListProcessing.Interfaces;

    public class InsertCommand : Command
    {
        public InsertCommand(string element, IListRepossitory listRepossitory, int index) 
            : base(element, listRepossitory, index)
        {

        }

        public override void Execute()
        {
            this.ListRepossitory.Insert(this.Index, this.Element);
            this.ListRepossitory.PrintWorkingList();
        }
    }
}
