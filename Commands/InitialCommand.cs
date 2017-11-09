namespace ListProcessing.Commands
{
    using System;
    using ListProcessing.Interfaces;

    public class InitialCommand : Command
    {
        public InitialCommand(string element, IListRepossitory listRepossitory) : base(element, listRepossitory)
        {
        }

        public override void Execute()
        {
            var elements = this.Element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var element in elements)
            {
                this.ListRepossitory.Append(element);
            }

            this.ListRepossitory.PrintWorkingList();
        }
    }
}
