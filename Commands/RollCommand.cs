namespace ListProcessing.Commands
{
    using System;
    using Interfaces;

    public class RollCommand : Command
    {
        private const string DirectionLeft = "left";
        private const string DirectionRight = "right";

        public RollCommand(string[] paramStrings, IListRepossitory listRepository, int index) 
            : base (paramStrings, listRepository)
        {

        }

        protected override void ValidateParams()
        {
            base.ValidateParams();
            if (this.ParamStrings[0] != DirectionLeft && this.ParamStrings[0] != DirectionRight)
            {
                throw new InvalidOperationException(Exceptions.InvalidParametersException);
            }
        }

        public override void Execute()
        {
            this.ValidateParams();

            if (this.ParamStrings[0] == DirectionLeft)
            {
                this.ListRepossitory.RollLeft();
                this.ListRepossitory.PrintWorkingList();
            }
            else
            {
                this.ListRepossitory.RollRight();
                this.ListRepossitory.PrintWorkingList();
            }
        }
    }
}