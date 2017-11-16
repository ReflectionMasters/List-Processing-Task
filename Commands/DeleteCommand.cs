using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
	class DeleteCommand : Command
	{
		public DeleteCommand(string element, IListRepossitory listRepository) 
			: base (element, listRepository)
		{

		}
		public override void Execute()
		{
			this.ListRepossitory.Delete(int.Parse(this.Element));
			this.ListRepossitory.PrintWorkingList();
		}
	}
}
