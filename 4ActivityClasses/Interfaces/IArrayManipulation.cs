namespace ArrayActivity.Interfaces
{
    public interface IArrayManipulation
    {
        void SetArray(int[] array);
        void Output();
        void SearchArray(int? target, bool? findLargestValue);
    }
}
