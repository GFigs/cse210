using System;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words = new List<Word>();

    public string toString()
    {
        return string.Format("{0}", _text);
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        foreach (string word in _text.Split(" ").ToList())
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.Write($"{_reference.toString()} ");
        foreach (Word word in _words)
        {
            if (word._isHidden)
            {
                int lenght = word._text.Length;
                Console.Write(string.Format("{0} ", new string('_', lenght)));
            }
            else
            {
                Console.Write(string.Format("{0} ", word._text));
            }
        }

    }

    public void hide_words()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _words.Count());
            if (_words[rndIndex]._isHidden == false)
            {
                _words[rndIndex]._isHidden = true;
                wordsRemoved++;
            }


        } while (wordsRemoved != numWordsToRemove);
    }

    public bool checkWordsLeft()
    {
        bool retValue = true;
        foreach (Word word in _words)
        {
            if (word._isHidden == false)
            {
                retValue = false;
                break;
            }
        }
        return retValue;
    }

}