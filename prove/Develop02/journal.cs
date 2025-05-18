using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    /// <summary>
    /// Represents a journal that stores multiple journal entries.
    /// </summary>
    public class Journal
    {
        private List<JournalEntry> _entries = new List<JournalEntry>();

        /// <summary>
        /// Adds a new entry to the journal.
        /// </summary>
        /// <param name="entry">The journal entry to add.</param>
        public void AddEntry(JournalEntry entry)
        {
            _entries.Add(entry);
        }

        /// <summary>
        /// Displays all journal entries in the console.
        /// </summary>
        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }

            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.FormatEntry());
            }
        }

        /// <summary>
        /// Saves all journal entries to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        public void SaveToFile(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                Console.WriteLine("Invalid filename. Please provide a valid file name.");
                return;
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToFileLine());
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }

        /// <summary>
        /// Loads journal entries from a file.
        /// </summary>
        /// <param name="filename">The name of the file to load from.</param>
        public void LoadFromFile(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                Console.WriteLine("Invalid filename. Please provide a valid file name.");
                return;
            }

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                try
                {
                    JournalEntry entry = JournalEntry.FromFileLine(line);
                    if (entry != null)
                    {
                        _entries.Add(entry);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error loading entry: {ex.Message}");
                }
            }

            Console.WriteLine($"Journal loaded from {filename}");
        }
    }
}