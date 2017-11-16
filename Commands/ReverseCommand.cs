using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class ReverseCommand :Command
	{
		public ReverseCommand(string element, IListRepossitory listRepository, int index) 
			: base (element, listRepository, index)
		{

		}
		public override void Execute()
		{
			this.ListRepossitory.Reverse();
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
