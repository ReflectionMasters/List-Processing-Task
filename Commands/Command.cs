namespace ListProcessing
{
    using Interfaces;

    public abstract class Command : IExecutable
    {
        private string element;
        private IListRepossitory listRepossitory;

        protected Command(string element, IListRepossitory listRepossitory)
        {
            this.Element = element;
            this.ListRepossitory = listRepossitory;
        }

        protected string Element { get => this.element; set => this.element = value; }

        protected IListRepossitory ListRepossitory { get => this.listRepossitory; set => this.listRepossitory = value; }

        public abstract void Execute();
    }
}
