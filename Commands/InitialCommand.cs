namespace ListProcessing.Commands
{
    using Interfaces;

    public class InitialCommand : Command
    {
        public InitialCommand(string[] paramStrings, IListRepossitory listRepossitory) 
            : base(paramStrings, listRepossitory)
        {
        }

        public override void Execute()
        {
            foreach (var element in this.ParamStrings)
            {
                this.ListRepossitory.Append(element);
            }

            this.ListRepossitory.PrintWorkingList();
        }
    }
}
