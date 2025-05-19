using System;
using JournalApp;

namespace JournalApp
{
    class Program
    {
        static void Main()
        {
            Journal journal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry(journal, promptGen);
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter file name to save journal: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        Console.WriteLine("Journal saved successfully.");
                        break;

                    case "4":
                        Console.Write("Enter file name to load journal: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        Console.WriteLine("Journal loaded successfully.");
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {   
            Console.WriteLine("welcome to the Journal App");
            Console.WriteLine("\n  Menu   ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
        }


        static void WriteNewEntry(Journal journal, PromptGenerator promptGen)
        {
            string prompt = promptGen.GetRandomPrompt();
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            JournalEntry entry = new JournalEntry(date, prompt, response);
            journal.AddEntry(entry);
            Console.WriteLine("Entry added.");
        }
    }
}