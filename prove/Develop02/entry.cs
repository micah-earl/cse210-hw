namespace JournalApp
{
    /// <summary>
    /// Represents a single journal entry with a date, prompt, and response.
    /// </summary>
    public class JournalEntry
    {
        private string Date { get; }
        private string Prompt { get; }
        private string Response { get; }
        public JournalEntry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
        public string FormatEntry()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n----------------------------------------";
        }
        public string ToFileLine()
        {
            return $"{Date}~|~{Prompt}~|~{Response}";
        }
        public static JournalEntry FromFileLine(string line)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length != 3)
            {
                throw new FormatException("Invalid file line format. Expected 3 parts separated by '~|~'.");
            }

            return new JournalEntry(parts[0], parts[1], parts[2]);
        }
    }
}
