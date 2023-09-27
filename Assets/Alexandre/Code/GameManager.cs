using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    CameraManager cameraManager;
    PreparationShipManager currentIronBloc;
    PreparationShipManager currentShieldBloc;
    PreparationShipManager currentGunBloc;
    PreparationShipManager currentCoreBloc;
    public static bool dogTurn = true;
    public GameObject canvaDebut;
    public GameObject canvaD4;
    public GameObject canvaCard;
    public GameObject canvaShipManager;
    public Text titleText, descriptionText;


    DogManager dogWay;
    DogManager dogMove;
    [Header("Character management")]
    [SerializeField] CatManager catWay;
    CatManager catMove;
    DeckReader deckReader;
    private int currentD;
    private Deck draw;

   

    private int turn;
    

    private void Awake()
    {
        canvaDebut.SetActive(true);
        canvaD4.SetActive(false);
        canvaCard.SetActive(false);
        canvaShipManager.SetActive(false);

        deckReader = this.GetComponent<DeckReader>();

        draw = GameObject.Find("GameManager").GetComponent<Deck>();
        dogWay = GameObject.Find("DogManager").GetComponent<DogManager>();
        dogMove = GameObject.Find("DogManager").GetComponent<DogManager>();
        catWay = GameObject.Find("CatManager").GetComponent<CatManager>();
        catMove = GameObject.Find("CatManager").GetComponent<CatManager>();

        cameraManager = GameObject.Find("GameManager").GetComponent<CameraManager>();
        currentIronBloc = GameObject.Find("GameManager").GetComponent<PreparationShipManager>();
        currentShieldBloc = GameObject.Find("GameManager").GetComponent<PreparationShipManager>();
        currentGunBloc = GameObject.Find("GameManager").GetComponent<PreparationShipManager>();
        currentCoreBloc = GameObject.Find("GameManager").GetComponent<PreparationShipManager>();
    }
    // Update is called once per frame

    public void ReceiveMessage(string message)
    {
        if(dogTurn == true)
        {
            if (message == "L")
            {
                canvaDebut.SetActive(false);
                dogWay.dogWay = "L";
                canvaD4.SetActive(true);
            }
            if (message == "M")
            {
                canvaDebut.SetActive(false);
                dogWay.dogWay = "M";
                canvaD4.SetActive(true);
            }
            if (message == "R")
            {
                canvaDebut.SetActive(false);
                dogWay.dogWay = "R";
                canvaD4.SetActive(true);
            }
        }
        else
        {
            if (message == "L")
            {
                canvaDebut.SetActive(false);
                catWay.catWay = "R";
                canvaD4.SetActive(true);
            }
            if (message == "M")
            {
                canvaDebut.SetActive(false);
                catWay.catWay = "M";
                canvaD4.SetActive(true);
            }
            if (message == "R")
            {
                canvaDebut.SetActive(false);
                catWay.catWay = "L";
                canvaD4.SetActive(true);
            }
        }
        

        if (message == "D4")
        {
            canvaCard.SetActive(true);
            canvaD4.SetActive(false);
            D4();
        }
        if (message == "Ok")
        {
            canvaCard.SetActive(false);

            if ((currentIronBloc.currentIron > 0 || currentGunBloc.currentGun > 0 || currentShieldBloc.currentShield > 0) && dogTurn == true)
            {
                canvaShipManager.SetActive(true);
                cameraManager.SwitchCam("DogShipCam");
            }
            else if ((currentIronBloc.currentIron > 0 || currentGunBloc.currentGun > 0 || currentShieldBloc.currentShield > 0) && dogTurn == false)
            {
                canvaShipManager.SetActive(true);
                cameraManager.SwitchCam("CatShipCam");
            }
            else
            {
                ReceiveMessage("FinDeTour");
            }

        }
        if (message == "FinDeTour")
        {
            canvaShipManager.SetActive(false);

            Debug.Log("fin du tour" + " - " + dogTurn);
            if (turn < 1)
            {
                canvaDebut.SetActive(true);
                currentIronBloc.currentIron = 3;
                    currentGunBloc.currentGun = 1;
                    currentShieldBloc.currentShield = 1;
                    currentCoreBloc.currentCore = 1;
            }
            else
            {
                canvaD4.SetActive(true);
            }
         

            if (dogTurn == true)
            {
                dogTurn = false;
                cameraManager.SwitchCam("CatTurnCam");
                turn += 1;
            }
            else
            {
                dogTurn = true;
                cameraManager.SwitchCam("DogTurnCam");
            }
            Debug.Log("fin du tour" + " - " + dogTurn);
        }
        void D4()
        {
            currentD = Random.Range(1, 5);
            //Debug.Log(currentD);
            if (dogTurn == true)
            {
                dogMove.move += currentD;
                if (dogMove.move <= 9 || (dogWay.dogWay == "M" && dogMove.move <= 6))
                {
                    draw.Draw();
                }
            }
            else
            {
                catMove.move += currentD;
                if (catMove.move <= 9 || (catWay.catWay == "M" && catMove.move <= 6))
                {
                    draw.Draw();
                }
            }
              
           

        }
    }
}


