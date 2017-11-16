using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class ReverseCommand :Command
	{
		public ReverseCommand(string element, IListRepossitory listRepository) 
			: base (element, listRepository)
		{

		}
		public override void Execute()
		{
			this.ListRepossitory.Reverse();
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
