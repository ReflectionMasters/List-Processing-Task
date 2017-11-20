namespace ListProcessing
{
    using System;
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;

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
                throw new ArgumentException(string.Format(Exceptions.InvalidIndexException, index));
            }

            workList.RemoveAt(index);
        }

        public void RollLeft()
        {
            string tmp = workList[0];
            workList.RemoveAt(0);
            workList.Add(tmp);
        }

        public void RollRight()
        {
            string tmp = workList.Last();
            workList.RemoveAt(workList.Count - 1);
            workList.Insert(0,tmp);
        }

        public void Sort()
        {
            this.workList.Sort();
        }

        public void Count(string element)
        {
            throw new NotImplementedException();
        }

        public void PrintWorkingList()
        {
            ConsoleManager.WriteLine(string.Join(" ", this.workList));
        }
    }
}
