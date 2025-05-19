using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
  
    public class Journal
    {
        private List<JournalEntry> _entries = new List<JournalEntry>();
        public void AddEntry(JournalEntry entry)
        {
            _entries.Add(entry);
        }

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