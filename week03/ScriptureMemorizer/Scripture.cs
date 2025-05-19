using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(Words.Count);
            Words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in Words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{Reference}\n{text.Trim()}";
    }
}