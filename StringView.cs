using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService _service = new StringService();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new text: ");
                        _service.SetText(Console.ReadLine() ?? "");
                        break;
                    case "2":
                        Console.WriteLine($"Current Text: [{_service.GetCurrentText()}]");
                        break;
                    case "3":
                        _service.ToUpper();
                        break;
                    case "4":
                        _service.ToLower();
                        break;
                    case "5":
                        Console.WriteLine($"Character Count: {_service.GetLength()}");
                        break;
                    case "6":
                        Console.Write("Word to find: ");
                        string word = Console.ReadLine() ?? "";
                        Console.WriteLine(_service.ContainsWord(word) ? "Found!" : "Not found.");
                        break;
                    case "7":
                        Console.Write("Word to replace: ");
                        string oldW = Console.ReadLine() ?? "";
                        Console.Write("New word: ");
                        string newW = Console.ReadLine() ?? "";
                        _service.ReplaceWord(oldW, newW);
                        break;
                    case "8":
                        Console.Write("Start index: ");
                        int start = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Length: ");
                        int len = int.Parse(Console.ReadLine() ?? "0");
                        _service.ExtractSubstring(start, len);
                        break;
                    case "9":
                        _service.TrimSpaces();
                        break;
                    case "10":
                        _service.ResetText();
                        Console.WriteLine("Text reset to original.");
                        break;
                    case "11":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--- String Processing System ---");
            Console.WriteLine("1. Enter Text\n2. View Current Text\n3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase\n5. Count Characters\n6. Check if Contains Word");
            Console.WriteLine("7. Replace Word\n8. Extract Substring\n9. Trim Spaces");
            Console.WriteLine("10. Reset Text\n11. Exit");
            Console.Write("\nSelect an option: ");
        }
    }
}
