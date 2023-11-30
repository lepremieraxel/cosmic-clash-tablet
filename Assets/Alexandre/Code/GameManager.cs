using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    CameraManager cameraManager;
    PreparationShipManager currentIronBloc;
    PreparationShipManager currentShieldBloc;
    PreparationShipManager currentGunBloc;
    PreparationShipManager currentCoreBloc;
    public static bool dogTurn = true;
    public static bool fight = false;

    CanvasManager canvasManager;

   
    DogManager dogWay;
    DogManager dogMove;
    [Header("Character management")]
    [SerializeField] CatManager catWay;
    CatManager catMove;
    private int currentD;
    private Deck draw;

    public static int maxCatGun;
    public static int maxDogGun;
    private int maxAttack;


    private int turn;

    private FightManager fightManager;
    private void Awake()
    {
        

        draw = this.GetComponent<Deck>();//remove si on utilise plus le Deck
        dogWay = GameObject.Find("DogManager").GetComponent<DogManager>();
        dogMove = GameObject.Find("DogManager").GetComponent<DogManager>();
        catWay = GameObject.Find("CatManager").GetComponent<CatManager>();
        catMove = GameObject.Find("CatManager").GetComponent<CatManager>();

        canvasManager = this.GetComponent<CanvasManager>();
        cameraManager = this.GetComponent<CameraManager>();
        currentIronBloc = this.GetComponent<PreparationShipManager>();
        currentShieldBloc = this.GetComponent<PreparationShipManager>();
        currentGunBloc = this.GetComponent<PreparationShipManager>();
        currentCoreBloc = this.GetComponent<PreparationShipManager>();
        fightManager = this.GetComponent<FightManager>();

        canvasManager.SwitchCanvas("canvasDebut");
    }
    // Update is called once per frame

    public void ReceiveMessage(string message)
    {
        if(dogTurn == true)
        {
            if (message == "L")
            {
                dogWay.dogWay = "L";
                canvasManager.SwitchCanvas("canvasD4");
            }
            if (message == "M")
            {
                
                dogWay.dogWay = "M";
                canvasManager.SwitchCanvas("canvasD4");
            }
            if (message == "R")
            {
                
                dogWay.dogWay = "R";
                canvasManager.SwitchCanvas("canvasD4");
            }
        }
        else
        {
            if (message == "L")
            {
                
                catWay.catWay = "R";
                canvasManager.SwitchCanvas("canvasD4");
            }
            if (message == "M")
            {
                
                catWay.catWay = "M";
                canvasManager.SwitchCanvas("canvasD4");
            }
            if (message == "R")
            {
                
                catWay.catWay = "L";
                canvasManager.SwitchCanvas("canvasD4");
            }
        }
        

        if (message == "D4")
        {
            canvasManager.SwitchCanvas("canvasCard");
            D4();
        }
        if (message == "Ok")
        {
            
            //simplifié dans le camera manager en fonction du tour

            if ((currentIronBloc.currentIron > 0 || currentGunBloc.currentGun > 0 || currentShieldBloc.currentShield > 0) && dogTurn == true)
            {
                canvasManager.SwitchCanvas("canvasShipManager");
                cameraManager.SwitchCam("DogShipCam");
            }
            else if ((currentIronBloc.currentIron > 0 || currentGunBloc.currentGun > 0 || currentShieldBloc.currentShield > 0) && dogTurn == false)
            {
                canvasManager.SwitchCanvas("canvasShipManager");
                cameraManager.SwitchCam("CatShipCam");
            }
            else
            {
                ReceiveMessage("FinDeTour");
            }

        }
        if (message == "FinDeTour")
        {
        

            Debug.Log("fin du tour" + " - " + dogTurn);
            if (turn < 1)
            {
                canvasManager.SwitchCanvas("canvasDebut");
                currentIronBloc.currentIron = 3;
                    currentGunBloc.currentGun = 1;
                    currentShieldBloc.currentShield = 1;
                    currentCoreBloc.currentCore = 1;
            }
            else if(dogMove.move == 0 || catMove.move ==0)
            {
                canvasManager.SwitchCanvas("canvasDebut");
            }
            else
            {
                canvasManager.SwitchCanvas("canvasD4");
            }
         

            if (dogTurn == true)
            {
                dogTurn = false;
                cameraManager.SwitchCam("ChangeTurnCam");
                turn += 1;
            }
            else
            {
                dogTurn = true;
                cameraManager.SwitchCam("ChangeTurnCam");
            }
            
        }
        if (message == "Restart")
        {
            canvasManager.SwitchCanvas("canvasDebut");
            dogMove.Restart();
            catMove.Restart();
            cameraManager.SwitchCam("ChangeTurnCam");
        }
        void D4()
        {
            currentD = Random.Range(1, 5);
            
            if (dogTurn == true)
            {
                dogMove.move += currentD;
                if (dogMove.move >= 9 || (dogWay.dogWay == "M" && dogMove.move >= 6))
                {
                    draw.Draw();
                    StartBattle("Dog");
                }
                else
                {
                    draw.Draw();
                }
            }
            else
            {
                catMove.move += currentD;
                if (catMove.move >= 9 || (catWay.catWay == "M" && catMove.move >= 6))
                {
                    draw.Draw();
                    StartBattle("Cat");
                }
                else
                {
                    draw.Draw();

                }
            }
              
           

        }
        

       
        
    }
    public void StartBattle(string Attacker)
    {
        if (Attacker == "Cat")
        {
            cameraManager.SwitchCam("DogShipCam");
            maxAttack = maxCatGun; //nb de tire= total de gun
            canvasManager.SwitchCanvas("canvasFire");
            fightManager.StartFight(maxCatGun);
        }
        else if (Attacker == "Dog")
        {
            cameraManager.SwitchCam("CatShipCam");
            maxAttack = maxDogGun;
            canvasManager.SwitchCanvas("canvasFire");
            fightManager.StartFight(maxDogGun);

        }

    }
}