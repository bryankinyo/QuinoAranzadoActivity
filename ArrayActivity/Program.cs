using System;
using ArrayActivity.Interfaces;
using ArrayActivity.Implementations;

namespace ArrayActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("========== MAIN MENU ==========");
                Console.WriteLine("| [1] Array Manipulation      |");
                Console.WriteLine("| [2] Linear Search           |");
                Console.WriteLine("| [3] String Reversal         |");
                Console.WriteLine("| [4] String Split and Count  |");
                Console.WriteLine("| [5] Exit                    |");
                Console.WriteLine("===============================");
                Console.Write("\nEnter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunArrayManipulation();
                        break;
                    case "2":
                        RunLinearSearch();
                        break;
                    case "3":
                        RunStringReversal();
                        break;
                    case "4":
                        RunStringSplitCount();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        Pause();
                        break;
                }
            }
        }
        static void RunArrayManipulation()
        {
            Console.Clear();
            Console.WriteLine("=== Array Manipulation ===");

            IArrayManipulation arrayOps = new ArrayManipulation();

            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        userArray[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }
            }

            arrayOps.SetArray(userArray);

            Console.WriteLine("\n--- Results ---");
            arrayOps.Output();
            arrayOps.SearchArray(null, true);
            Array.Reverse(userArray);
            Console.WriteLine("Reversed Array: " + string.Join(", ", userArray));
            Pause();
        }

        //static void RunArrayManipulation()
        //{
        //    Console.Clear();
        //    Console.WriteLine("=== Array Manipulation ===");

        //    IArrayManipulation arrayOps = new ArrayManipulation();
        //    arrayOps.SetArray(new int[] { 10, 25, 7, 99, 45 });
        //    arrayOps.Output();
        //    arrayOps.SearchArray(null, true);  
        //    arrayOps.SearchArray(99, null);    

        //    Pause();
        //}

        static void RunLinearSearch()
        {
            Console.Clear();
            Console.WriteLine("=== Linear Search ===");

            ILinearSearch searchOps = new LinearSearch();

            Console.Write("How many values do you want in the array? ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input.");
                Console.Write("How many values do you want in the array? ");
            }

            int[] userArray = new int[size];
            for (int i = 0; i < userArray.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        userArray[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }
            }

            Console.WriteLine("\nYour Array: " + string.Join(", ", userArray));

            Console.Write("\nEnter number to search: ");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                int index = searchOps.Search(userArray, target);
                Console.WriteLine(index != -1
                    ? $"Found {target} at index {index}"
                    : $"{target} not found in array.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Pause();
        }

        static void RunStringReversal()
        {
            Console.Clear();
            Console.WriteLine("=== String Reversal ===");

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            IStringReversal strRev = new StringReversal();
            Console.WriteLine($"Original: {word}");
            Console.WriteLine($"Reversed: {strRev.Reverse(word)}");

            Pause();
        }

        static void RunStringSplitCount()
        {
            Console.Clear();
            Console.WriteLine("=== String Split and Count ===");

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            IStringSplitCount strSplit = new StringSplitCount();
            Console.WriteLine($"Word Count: {strSplit.CountWords(sentence)}");

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
        }
    }
}
