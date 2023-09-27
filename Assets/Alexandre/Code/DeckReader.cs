using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeckReader : MonoBehaviour
{
    [SerializeField] string path = "Assets/Alexandre/Deck.csv";
    [SerializeField] int nbLines = 0;

    public class Card
    {
        public string id;
        public string title;
        public string description;
        public string function;
    }

    public Card RandomCard()
    {
        string[] lines = File.ReadAllLines(path);
        nbLines = lines.Length;
        int random = Random.Range(1, nbLines);
        string[] choosenLine = lines[random].Split(';');
        Card card = new Card
        {
            id = choosenLine[0],
            title = choosenLine[1],
            description = choosenLine[2],
            function = choosenLine[3]
        };
        return card;
    }
}
