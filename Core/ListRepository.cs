namespace ListProcessing
{
    using Interfaces;
    using System.Collections.Generic;

    public class ListRepository : IListRepossitory
    {
        private List<string> workList = new List<string>();

        public void Append(string elements)
        {
            workList.Add(elements);
        }

        public void Prepend(string element)
        {
            throw new System.NotImplementedException();
        }

        public void Reverse()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, string element)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new System.NotImplementedException();
        }

        public void RollLeft(string element)
        {
            throw new System.NotImplementedException();
        }

        public void RollRight(string element)
        {
            throw new System.NotImplementedException();
        }

        public void Sort(string element)
        {
            throw new System.NotImplementedException();
        }

        public void Count(string element)
        {
            throw new System.NotImplementedException();
        }

        public void PrintWorkingList()
        {
            ConsoleManager.WriteLine(string.Join(" ", this.workList));
        }
    }
}
