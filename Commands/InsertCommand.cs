namespace ListProcessing.Commands
{
    using Interfaces;

    public class InsertCommand : IndexCommand
    {
        private const int ExpectedParamsCount = 2;

        public InsertCommand(string[] paramStrings, IListRepossitory listRepossitory)
            : base(paramStrings, listRepossitory)
        {
            this.ParamsCount = ExpectedParamsCount;
        }

        public override void Execute()
        {
            this.ValidateParams();
            this.ListRepossitory.Insert(this.Index, this.ParamStrings[1]);
            this.ListRepossitory.PrintWorkingList();
        }
    }
}
