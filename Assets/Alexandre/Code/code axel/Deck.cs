using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public Text titleText, descriptionText;
    DeckReader deckReader;
    PreparationShipManager myRessources;
    private void Awake()
    {
        myRessources = FindObjectOfType<PreparationShipManager>();
        deckReader = GetComponent<DeckReader>();
    }
    void Update()
    {

    }
    public bool Draw()
    {
        DeckReader.Card card = deckReader.TakeACard();
        Regex addRegex = new Regex(@"ADD");
        if (card != null)
        {
            if (addRegex.IsMatch(card.function))
            {
                int fers = int.Parse(card.function.Split('-')[1]);
                int boucliers = int.Parse(card.function.Split('-')[2]);
                int armes = int.Parse(card.function.Split('-')[3]);
                myRessources.AddRessource(fers, boucliers, armes);
            }
            descriptionText.text = card.description;
            titleText.text = card.title;
            return true;
        }
        else
        {
            Debug.Log("No more cards");
            return false;
        }
    }
}
