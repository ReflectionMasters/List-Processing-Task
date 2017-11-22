namespace ListProcessing.Commands
{
    using System;
    using Interfaces;

    public abstract class IndexCommand : Command
    {
        private int index;

        protected IndexCommand(string[] paramStrings, IListRepossitory listRepossitory) 
            : base(paramStrings, listRepossitory)
        {
            
        }
        
        protected override void ValidateParams()
        {
            base.ValidateParams();

            int tmpIndex;

            bool isInteger = int.TryParse(this.ParamStrings[0], out tmpIndex);

            if (!isInteger)
            {
                throw new ArgumentException(Exceptions.InvalidParametersException);
            }

            this.Index = tmpIndex;
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }
    }
}