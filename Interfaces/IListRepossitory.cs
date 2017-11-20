namespace ListProcessing.Interfaces
{
    public interface IListRepossitory
    {
        void Append(string element);

        void Prepend(string element);

        void Reverse();
   
        void Insert(int index, string element);

        void Delete(int index);

        void RollLeft();

        void RollRight();

        void Sort();

        void Count(string element);

        void PrintWorkingList();
    }
}
