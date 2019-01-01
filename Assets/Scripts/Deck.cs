using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Deck
{
    private string[] cards;
    private string error;
    private int deckIndex;
    public Deck(string path)
    {
        deckIndex = 0;
        error = "";
        try
        {
            cards = System.IO.File.ReadAllLines(path);
        }
        catch (DirectoryNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
            error = e.Message;
            return;
        }
    }

    public String GetError()
    {
        return error;
    }

    public void Shuffle()
    {
        Random random = new Random();
        for(int count = 0; count < cards.Length; count++)
        {
            int old = random.Next(0, cards.Length),
                current = random.Next(0, cards.Length);
            string temp = cards[old];
            cards[old] = cards[current];
            cards[current] = temp;
        }
        deckIndex = 0;
    }

    public string Draw()
    {
        string card = cards[deckIndex];
        deckIndex = (deckIndex > cards.Length - 1) ? 0 : deckIndex + 1;        
        return card;
    }
}
