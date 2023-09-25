using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    private bool drawPowerCard;
    private bool drawRessourceCard;
    private int myDraw;
    [SerializeField] private string description;
    [SerializeField] private string title;
    public Text titleText, descriptionText;
    DeckReader deckReader;
    PreparationShipManager myRessources;
    private void Awake()
    {
        myRessources= FindObjectOfType<PreparationShipManager>();
        deckReader = this.GetComponent<DeckReader>();
    }
    void Update()
    {
        if (drawRessourceCard == true)
        {
            DeckReader.Card card = deckReader.RandomCard();
            myDraw = Random.Range(1,101);
            if (myDraw >= 1 && myDraw < 26)
            {
                if(myDraw >= 1 && myDraw < 13)
                {
                    title = "Débris spatial";
                }
                if (myDraw >= 13 && myDraw < 26)
                {
                    title = "Conserve vide";
                }
                description = "+ 1 fer";
                myRessources.AddRessource(1, 0, 0);
            }
            if (myDraw >= 26 && myDraw < 41)
            {
                if (myDraw >= 26 && myDraw < 32)
                {
                    title = "Astéroïde riche en fer";
                }
                if (myDraw >= 32 && myDraw < 41)
                {
                    title = "Planète minière";
                }
                description = "+ 2 fers";
                myRessources.AddRessource(2, 0, 0);
            }
            if (myDraw >= 41 && myDraw < 56)
            {
                if (myDraw >= 41 && myDraw < 48)
                {
                    title = "Débris de fusée";
                }
                if (myDraw >= 48 && myDraw < 56)
                {
                    title = "Marchand ambulant";
                }
                description = "+ 1 fer et 1 bouclier";
                myRessources.AddRessource(1, 1, 0);
            }
            if (myDraw >= 56 && myDraw < 81)
            {
                if (myDraw >= 56 && myDraw < 67)
                {
                    title = "Sac de croquettes";
                }
                if (myDraw >= 67 && myDraw < 81)
                {
                    title = "Morceaux de pierre";
                }
                description = "+ 1 bouclier";
                myRessources.AddRessource(0, 1, 0);
            }
            if (myDraw >= 81 && myDraw < 96)
            {
                if (myDraw >= 81 && myDraw < 88)
                {
                    title = "Champs d'astéroïdes";
                }
                if (myDraw >= 88 && myDraw < 96)
                {
                    title = "Palette de sac de croquettes";
                }
                description = "+ 2 boucliers";
                myRessources.AddRessource(0, 2, 0);
            }
            if (myDraw >= 96 && myDraw < 101)
            {
                title = "Canon laser";
                description = "+ 1 arme";
                myRessources.AddRessource(0, 0, 1);
            }
            descriptionText.text = card.description;
            titleText.text = card.title;
            drawRessourceCard = false;
        }
        if (drawPowerCard == true)
        {
            drawPowerCard = false;
            myDraw = Random.Range(1,7);
            if (myDraw == 1)
            {
                description = " ";
                //superPouvoir
            }
            if (myDraw == 2)
            {
                description = " ";
                //superPouvoir
            }
            if (myDraw == 3)
            {
                description = " ";
                //superPouvoir
            }
            if (myDraw == 4)
            {
                description = " ";
                //superPouvoir
            }
            if (myDraw == 5)
            {
                description = " ";
                //superPouvoir
            }
            if (myDraw == 6)
            {
                description = " ";
                //superPouvoir
            }
            drawPowerCard = false;
        }
        

    }
    public void Draw(bool ressourceCard, bool powerCard)
    {
        drawPowerCard = powerCard;
        drawRessourceCard = ressourceCard;
    }
}
