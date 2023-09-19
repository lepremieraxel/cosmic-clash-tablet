using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private bool drawPowerCard;
    private bool drawRessourceCard;
    private int myDraw;
    [SerializeField] private string description;

    PreparationShipManager myRessources;
    private void Awake()
    {
        myRessources= FindObjectOfType<PreparationShipManager>();
    }
    void Update()
    {
        if (drawRessourceCard == true)
        {
            
            myDraw = 1; //Random.Range(1,33);
            if (myDraw == 1)
            {
                description = "Snoop Dog";
                myRessources.AddRessource(0, 1, 1);
                
            }
            if (myDraw == 2)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 3)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 4)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 5)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 6)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 7)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 8)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 9)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 10)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 11)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 12)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 13)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 14)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 15)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 16)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 17)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 18)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 19)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 20)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 21)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 22)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 23)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 24)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 25)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 26)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 27)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 28)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 29)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 30)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 31)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
            if (myDraw == 32)
            {
                description = " ";
                myRessources.AddRessource(0, 0, 0);
            }
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
