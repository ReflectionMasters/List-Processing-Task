using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class PrependCommand : Command
	{
		public PrependCommand(string element, IListRepossitory listRepository, int index) 
			: base (element, listRepository, index)
		{

		}
		public override void Execute()
		{
			this.ListRepossitory.Prepend(this.Element);
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
