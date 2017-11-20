namespace ListProcessing.Commands
{
    using System;
    using Interfaces;

    public class RollCommand : Command
    {
        public RollCommand(string element, IListRepossitory listRepository, int index) 
            : base (element, listRepository, index)
        {

        }

        public override void Execute()
        {
            if (this.Element == "left")
            {
                this.ListRepossitory.RollLeft();
                this.ListRepossitory.PrintWorkingList();
            }
            else if (this.Element == "right")
            {
                this.ListRepossitory.RollRight();
                this.ListRepossitory.PrintWorkingList();
            }
            else
            {
                throw new InvalidOperationException(Exceptions.InvalidCommandException);
            }
            
        }
    }
}