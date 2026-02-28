using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService _service = new StringService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        EnterText();
                        break;

                    case "2":
                        ViewText();
                        break;

                    case "3":
                        _service.ToUpperCase();
                        Console.WriteLine("Converted to UPPERCASE.");
                        break;

                    case "4":
                        _service.ToLowerCase();
                        Console.WriteLine("Converted to lowercase.");
                        break;

                    case "5":
                        Console.WriteLine("Character Count: " + _service.CountCharacters());
                        break;

                    case "6":
                        CheckContains();
                        break;

                    case "7":
                        ReplaceWord();
                        break;

                    case "8":
                        ExtractSubstring();
                        break;

                    case "9":
                        _service.TrimSpaces();
                        Console.WriteLine("Spaces trimmed.");
                        break;

                    case "10":
                        _service.ResetText();
                        Console.WriteLine("Text reset to original.");
                        break;

                    case "11":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("===== STRING PROCESSING SYSTEM =====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.WriteLine("====================================");
        }

        private void EnterText()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            _service.SetText(text);
            Console.WriteLine("Text saved.");
        }

        private void ViewText()
        {
            Console.WriteLine("Current Text: " + _service.GetText());
        }

        private void CheckContains()
        {
            Console.Write("Enter word to check: ");
            string word = Console.ReadLine();

            bool result = _service.ContainsWord(word);

            if (result)
                Console.WriteLine("Word found!");
            else
                Console.WriteLine("Word not found.");
        }

        private void ReplaceWord()
        {
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            _service.ReplaceWord(oldWord, newWord);
            Console.WriteLine("Word replaced.");
        }

        private void ExtractSubstring()
        {
            Console.Write("Enter start index: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());

            try
            {
                _service.ExtractSubstring(start, length);
                Console.WriteLine("Substring extracted.");
            }
            catch
            {
                Console.WriteLine("Invalid index or length.");
            }
        }
    }
}
