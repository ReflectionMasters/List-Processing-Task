using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class DeleteCommand : Command
	{
		public DeleteCommand(string element, IListRepossitory listRepository, int index) 
			: base (element, listRepository, index)
		{

		}
		public override void Execute()
		{
			this.ListRepossitory.Delete(this.Index);
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
