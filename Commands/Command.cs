namespace ListProcessing
{
    using System;
    using Interfaces;

    public abstract class Command : IExecutable
    {
        private const int DefaultParamsCount = 0;
        private string[] paramStrings;
        private IListRepossitory listRepossitory;

        protected Command(string[] paramStrings, IListRepossitory listRepossitory)
        {
            this.ParamStrings = paramStrings;
            this.ListRepossitory = listRepossitory;
            this.ParamsCount = DefaultParamsCount;
        }

        protected string[] ParamStrings { get => this.paramStrings; set => this.paramStrings = value; }

        protected IListRepossitory ListRepossitory { get => this.listRepossitory; set => this.listRepossitory = value; }

        protected int ParamsCount { get; set; }

        protected virtual void ValidateParams()
        {
            if (ParamStrings.Length != ParamsCount)
            {
                throw new ArgumentException(Exceptions.InvalidParametersException);
            }
        }

        public abstract void Execute();
    }
}
