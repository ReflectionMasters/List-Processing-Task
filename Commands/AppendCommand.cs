namespace ListProcessing.Commands
{
    using Interfaces;

    public class AppendCommand : Command
    {
        private const int ExpectedParamsCount = 1;

        public AppendCommand(string[] paramStrings, IListRepossitory listRepository) 
            : base (paramStrings, listRepository)
        {
            this.ParamsCount = ExpectedParamsCount;
        }

        public override void Execute()
        {
            this.ValidateParams();
            this.ListRepossitory.Append(this.ParamStrings[0]);
            this.ListRepossitory.PrintWorkingList();
        }
    }
}
