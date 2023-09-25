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
    // Start is called before the first frame update
    void Start()
    {
        string[] lines = File.ReadAllLines(path);
        nbLines = lines.Length;
        RandomCard();
    }

    public class Card
    {
        public string id;
        public string title;
        public string description;
        public string function;
    }

    public Card RandomCard()
    {
        int random = Random.Range(1, nbLines);
        string[] lines = File.ReadAllLines(path);
        string[] choosenLine = lines[random].Split(';');
        Card card = new Card();
        card.id = choosenLine[0];
        card.title = choosenLine[1];
        card.description = choosenLine[2];
        card.function = choosenLine[3];
        return card;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
