using System;
using ArrayActivity.Interfaces;

namespace ArrayActivity.Implementations
{
    public class ArrayManipulation : IArrayManipulation
    {
        private int[] _array;

        public void SetArray(int[] array)
        {
            _array = array;
        }

        public void Output()
        {
            Console.WriteLine("Array values: " + string.Join(", ", _array));
        }

        public void SearchArray(int? target, bool? findLargestValue)
        {
            if (findLargestValue == true)
            {
                int largest = _array[0];
                foreach (var num in _array)
                    if (num > largest) largest = num;

                Console.WriteLine($"Largest Value: {largest}");
            }

            if (target != null)
            {
                int index = Array.IndexOf(_array, target.Value);
                Console.WriteLine(index != -1
                    ? $"Target {target.Value} found at index {index}"
                    : $"Target {target.Value} not found");
            }
        }
    }
}
