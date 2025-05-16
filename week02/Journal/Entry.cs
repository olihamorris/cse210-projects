using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public string GetDisplay()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string GetSaveText()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromSavedText(string line)
    {
        string[] parts = line.Split('|');

        if (parts.Length == 3)
        {
            return new Entry
            {
                Date = parts[0],
                Prompt = parts[1],
                Response = parts[2]
            };
        }
        else
        {
            throw new FormatException("Invalid entry format.");
        }
    }
}