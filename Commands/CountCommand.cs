using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
    public class CountCommand : Command
    {
        private const int ExpectedParamsCount = 1;

        public CountCommand(string[] paramStrings, IListRepossitory listRepository)
            : base(paramStrings, listRepository)
        {
            this.ParamsCount = ExpectedParamsCount;
        }

        public override void Execute()
        {
            this.ValidateParams();
            this.ListRepossitory.Count(this.ParamStrings[0]);
        }
    }
}
