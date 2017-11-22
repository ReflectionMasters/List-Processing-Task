using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class DeleteCommand : IndexCommand
	{
	    private const int ExpectedParamsCount = 1;

        public DeleteCommand(string[] paramStrings, IListRepossitory listRepository) 
			: base (paramStrings, listRepository)
        {
            this.ParamsCount = ExpectedParamsCount;
        }
		public override void Execute()
		{
            base.ValidateParams();
            this.ListRepossitory.Delete(this.Index);
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
