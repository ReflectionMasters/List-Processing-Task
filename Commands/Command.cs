namespace ListProcessing
{
    using System;
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
            this.ParamsCount = 0;
        }

        protected string Element { get => this.element; set => this.element = value; }

        protected int Index { get => this.index; set => this.index = value; }

        protected IListRepossitory ListRepossitory { get => this.listRepossitory; set => this.listRepossitory = value; }

        protected int ParamsCount { get; set; }

        public virtual void ValidateParams(int parametersCount)
        {
            if (parametersCount != ParamsCount)
            {
                throw new ArgumentException(Exceptions.InvalidParametersException);
            }
        }

        public abstract void Execute();
    }
}
