namespace ListProcessing.Interfaces
{
    public interface IListRepossitory
    {
        void Append(string element);

        void Prepend(string element);

        void Reverse();
   
        void Insert(int index, string element);

        void Delete(int index);

        void RollLeft(string element);

        void RollRight(string element);

        void Sort(string element);

        void Count(string element);

        void PrintWorkingList();
    }
}
