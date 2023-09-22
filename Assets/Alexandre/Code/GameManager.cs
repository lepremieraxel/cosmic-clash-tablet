using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    CameraManager cameraManager;
    PreparationShipManager currentIronBloc;
    PreparationShipManager currentShieldBloc;
    PreparationShipManager currentGunBloc;
    public static bool dogTurn = true;
    public GameObject canvaDebut;
    public GameObject canvaD4;
    public GameObject canvaCard;
    public GameObject canvaShipManager;

    DogManager dogWay;
    DogManager dogMove;
    private int currentD;
    private Deck draw;

    private int turn;
    

    private void Awake()
    {
        canvaDebut.SetActive(true);
        canvaD4.SetActive(false);
        canvaCard.SetActive(false);
        canvaShipManager.SetActive(false);

        draw = FindObjectOfType<Deck>();
        dogWay = GameObject.Find("DogManager").GetComponent<DogManager>();
        dogMove = GameObject.Find("DogManager").GetComponent<DogManager>();

        cameraManager = GameObject.Find("GameManager").GetComponent<CameraManager>();
        currentIronBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
        currentShieldBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
        currentGunBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();

    }
    // Update is called once per frame

    public void ReceiveMessage(string message)
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
            if (dogTurn == true)

                currentD = Random.Range(1, 5);
            Debug.Log(currentD);
            dogMove.move += currentD;
            if (dogMove.move >= 9 || (dogWay.dogWay == "M" && dogMove.move >= 6))
            {
                draw.Draw(false, true);
            }
            else
            {
                draw.Draw(true, false);
            }

        }
    }
}


