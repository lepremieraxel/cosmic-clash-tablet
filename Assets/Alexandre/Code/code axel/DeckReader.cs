using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeckReader : MonoBehaviour
{
    [SerializeField] string path = "Assets/CSV/Deck.csv";
    [SerializeField] int nbLines = 0;
    private int random;
    [SerializeField] private List<string> pulledCards = new List<string>();
    private string[] choosenCard;
    private string[] lines;

    public class Card
    {
        public string id;
        public string title;
        public string description;
        public string function;
    }

    private int GetRandom(int min, int max)
    {
        int r = Random.Range(min, max);
        return r;
    }

    public Card TakeACard()
    {
        lines = File.ReadAllLines(path);
        nbLines = lines.Length;
        random = GetRandom(1, nbLines);
        if (!pulledCards.Contains(random.ToString()) && pulledCards.Count < nbLines - 1)
        {
            choosenCard = lines[random].Split(';');
            pulledCards.Add(choosenCard[0]);
            Card card = new Card
            {
                id = choosenCard[0],
                title = choosenCard[1],
                description = choosenCard[2],
                function = choosenCard[3]
            };
            return card;
        }
        else if (pulledCards.Count >= nbLines - 1)
        {
            Debug.Log("Empty deck");
            return null;
        }
        else
        {
            return TakeACard();
        }

    }
}