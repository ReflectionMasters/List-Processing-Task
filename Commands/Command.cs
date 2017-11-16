namespace ListProcessing
{
    using Interfaces;

    public abstract class Command : IExecutable
    {
        private string element;
        private int index;
        private IListRepossitory listRepossitory;

        protected Command(string element, IListRepossitory listRepossitory, int index)
        {
            this.Index = index;
            this.Element = element;
            this.ListRepossitory = listRepossitory;
        }

        protected string Element { get => this.element; set => this.element = value; }

        protected int Index { get => this.index; set => this.index = value; }

        protected IListRepossitory ListRepossitory { get => this.listRepossitory; set => this.listRepossitory = value; }

        public abstract void Execute();
    }
}
