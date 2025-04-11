using LeetCodeAlgorithms.BL.Tasks.TwoSum;
using LeetCodeAlgorithms.BL.Tasks.LongestSubstring;
using LeetCodeAlgorithms.BL.Tasks.PascalTriangle;

Console.WriteLine("Leet Code Algorithms run!");

void DisplayMenu()
{
    Console.WriteLine("\nPlease choose a task:\n" +
                      "1 - \"Two Sum\"\n" +
                      "2 - \"Pascal's Triangle\"\n" +
                      "3 - \"Longest Substring Without Repeating Characters\"\n" +
                      "_______________________________________________\n" +
                      "0 - Exit");
    Console.WriteLine();
}

int number;
do
{
    DisplayMenu();
    number = int.TryParse(Console.ReadLine(), out int input) ? input : -1;

    switch (number)
    {
        case 1:
            new TwoSumTask().Execute();
            break;
        case 2:
            new PascalTriangleTask().Execute();
            break;
        case 3:
            new LongestSubstringTask().Execute();
            break;
        case 0:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
} while (number != 0);