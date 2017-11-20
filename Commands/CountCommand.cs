using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
    class CountCommand : Command
    {
        public CountCommand(string element, IListRepossitory listRepository, int index)
            : base(element, listRepository, index)
        {

        }
        public override void Execute()
        {
            this.ListRepossitory.Count(this.Element);
        }
    }
}
