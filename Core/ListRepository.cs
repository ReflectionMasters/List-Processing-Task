namespace ListProcessing
{
    using System;
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
            workList.Insert(0, element);
        }

        public void Reverse()
        {
            workList.Reverse();
        }

        public void Insert(int index, string element)
        {
            workList.Insert(index, element);
        }

        public void Delete(int index)
        {
            if (index < 0 || index > workList.Count - 1)
            {
                ConsoleManager.WriteLine(String.Format(Exceptions.InvalidIndexException, index));
            }

            workList.RemoveAt(index);
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
