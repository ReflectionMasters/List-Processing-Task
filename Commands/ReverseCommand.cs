using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class ReverseCommand : Command
	{
		public ReverseCommand(string[] paramStrings, IListRepossitory listRepository) 
			: base (paramStrings, listRepository)
		{

		}

		public override void Execute()
		{
            this.ValidateParams();
            this.ListRepossitory.Reverse();
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
