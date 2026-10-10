using System;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        List<JournalEntry> entries = new List<JournalEntry>();

        int response = 0;
        

         

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
            case 1:
                Console.WriteLine("create");
                 JournalEntry newEntry = new JournalEntry();
                 newEntry.CreateJournalEntry();
                 entries.Add(newEntry);
                break;
            case 2:
                Console.WriteLine("display");
                foreach (JournalEntry entry in entries)
                {
                    entry.DisplayEntry();
                }
                Console.WriteLine($"You've writen a total of {entries.Count} enties. Good job!");
                break;
            case 3:
                Console.WriteLine("Filename here:");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (JournalEntry entry in entries)
                    {
                        outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                    }
                }
                break;
            case 4:
                Console.WriteLine("read");
                Console.WriteLine("what file do you want to read?:");
                string loadFilename = Console.ReadLine();
                string[] lines = File.ReadAllLines(loadFilename);
                entries.Clear();
                foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        JournalEntry loadedEntry = new JournalEntry();
                        loadedEntry._date = parts[0];
                        loadedEntry._prompt = parts[1];
                        loadedEntry._response = parts[2];
                        entries.Add(loadedEntry);
                    }
                break;

            }
        }
    }
}