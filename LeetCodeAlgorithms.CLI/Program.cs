using LeetCodeAlgorithms.BL.Tasks.TwoSum;
using LeetCodeAlgorithms.BL.Tasks.LongestSubstring;
using LeetCodeAlgorithms.BL.Tasks.PascalTriangle;
using LeetCodeAlgorithms.BL.Tasks;

// https://leetcode.com/problemset/

Console.WriteLine("Leet Code Algorithms run!");

void DisplayMenu()
{
    Console.WriteLine("\nPlease choose a task:\n" +
                      "1 - \"Two Sum\"\n" +
                      "2 - \"Pascal's Triangle\"\n" +
                      "3 - \"Longest Substring Without Repeating Characters\"\n" +
                      "4 - \"Longest Common Prefix\"\n" +
                      "26. Remove Duplicates from Sorted Array \n" +
                      "_______________________________________________\n" +
                      "0 - Exit");
    Console.WriteLine();
}

int number;

do
{
    IExecutableTask? task = null;

    DisplayMenu();
    number = int.TryParse(Console.ReadLine(), out int input) ? input : -1;

    switch (number)
    {
        case 1:
            task = new TwoSumTask();
            break;
        case 2:
            task = new PascalTriangleTask();
            break;
        case 3:
            task = new LongestSubstringTask();
            break;
        case 4:
            task = new LongestCommonPrefixTask();
            break;
        case 26:
            task = new RemoveDuplicatesFromSortedArrayTask();
            break;
        case 0:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }

    task?.Execute();

    Console.ReadLine();
} while (number != 0);