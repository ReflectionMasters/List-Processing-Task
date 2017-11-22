using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class PrependCommand : Command
	{
	    private const int ExpectedParamsCount = 1;

        public PrependCommand(string[] paramStrings, IListRepossitory listRepository) 
			: base (paramStrings, listRepository)
        {
            this.ParamsCount = ExpectedParamsCount;
        }
		public override void Execute()
		{
		    this.ValidateParams();
            this.ListRepossitory.Prepend(this.ParamStrings[0]);
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
