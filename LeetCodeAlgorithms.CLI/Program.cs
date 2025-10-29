using LeetCodeAlgorithms.BL.Tasks.TwoSum;
using LeetCodeAlgorithms.BL.Tasks.LongestSubstring;
using LeetCodeAlgorithms.BL.Tasks.PascalTriangle;
using LeetCodeAlgorithms.BL.Tasks;

// https://leetcode.com/problemset/

Console.WriteLine("Leet Code Algorithms run!");

void DisplayMenu()
{
    Console.WriteLine("\nPlease choose a task: \n" +
                      "1. Two Sum \n" +
                      "2. Pascal's Triangle \n" +
                      "3. Longest Substring Without Repeating Characters \n" +
                      "4. Longest Common Prefix \n" +
                      "9. Palindrome Number \n" +
                      "13. Roman to Integer \n" +
                      "20. Valid Parentheses \n" +
                      "21. Merge Two Sorted Lists \n" +
                      "26. Remove Duplicates from Sorted Array \n" +
                      "27. Remove Element \n" +
                      "28. Find the Index of the First Occurrence in a String \n" +
                      "35. Search Insert Position \n" +
                      "58. Length of Last Word \n" +
                      "66. Plus One \r\n" +
                      "67. Add Binary \r\n" +
                      "69. Sqrt(x) \r\n" +
                      "70. Climbing Stairs \r\n" +
                      "83. Remove Duplicates from Sorted List \r\n" +
                      "88. Merge Sorted Array \r\n" +
                      "100. Same Tree\r\n" +
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
        case 9:
            task = new PalindromeNumberTask();
            break;
        case 13:
            task = new RomanToIntegerTask();
            break;
        case 20:
            task = new ValidParenthesesTask();
            break;
        case 21:
            task = new MergeTwoSortedListsTask();
            break;
        case 26:
            task = new RemoveDuplicatesFromSortedArrayTask();
            break;
        case 27:
            task = new RemoveElementTask();
            break;
        case 28:
            task = new FirstOccurrenceIndexTask();
            break;
        case 35:
            task = new SearchInsertPositionTask();
            break;
        case 58:
            task = new LengthOfLastWordTask();
            break;
        case 66:
            task = new PlusOneTask();
            break;
        case 67:
            task = new AddBinaryTask();
            break;
        case 69:
            task = new SqrtXTask();
            break;
        case 70:
            task = new ClimbingStairsTask();
            break;
        case 83:
            task = new RemoveDuplicatesFromSortedListTask();
            break;
        case 88:
            task = new MergeSortedArrayTask();
            break;
        case 100:
            task = new SameTreeTask();
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