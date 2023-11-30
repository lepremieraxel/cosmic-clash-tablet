using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{

    private int dice;
    private string ligneOrColonne;
    private string rightOrLeft;
    CanvasManager canvasManager;
    private int shotNumber;
    public Text shotNumberText;
    private int round = 0;
    public GameManager gameManager;
    public CameraManager cameraManager;

    void Start()
    {
        canvasManager = this.GetComponent<CanvasManager>();
        gameManager = this.GetComponent<GameManager>();
        cameraManager = this.GetComponent<CameraManager>();
    }

    public void StartFight(int weaponCount)//on lance le dée pour savoir ou on va tiré
    {
        shotNumber = weaponCount;
        dice = Random.Range(1, 7);
        Debug.Log(dice);
        canvasManager.SwitchCanvas("canvasChoseLineOrColumn");
        

    }

    public void ReceiveMessage(string message)//je joueur choisi ligne ou colonne
    {
        if (message == "Line")
        {
            ligneOrColonne = "Line";
            canvasManager.SwitchCanvas("canvasChoseRightOrLeft");
        }
        else if (message == "Column")
        {
            ligneOrColonne = "Column";
            canvasManager.SwitchCanvas("canvasChoseRightOrLeft");
        }
        if (message == "Right")
        {
            rightOrLeft = "Right";
            Fire(dice, ligneOrColonne, rightOrLeft);

        }
        else if (message == "Left")
        {
            rightOrLeft = "Left";
            Fire(dice, ligneOrColonne, rightOrLeft);

        }

    }

    public Transform DogL1;
    public Transform DogL2;
    public Transform DogL3;
    public Transform DogL4;
    public Transform DogL5;
    public Transform DogL6;
    public Transform DogR1;
    public Transform DogR2;
    public Transform DogR3;
    public Transform DogR4;
    public Transform DogR5;
    public Transform DogR6;
    public Transform DogUP1;
    public Transform DogUP2;
    public Transform DogUP3;
    public Transform DogUP4;
    public Transform DogUP5;
    public Transform DogUP6;
    public Transform DogDOWN1;
    public Transform DogDOWN2;
    public Transform DogDOWN3;
    public Transform DogDOWN4;
    public Transform DogDOWN5;
    public Transform DogDOWN6;

    public GameObject projectilPrefab;

    public Transform CatL1;
    public Transform CatL2;
    public Transform CatL3;
    public Transform CatL4;
    public Transform CatL5;
    public Transform CatL6;
    public Transform CatR1;
    public Transform CatR2;
    public Transform CatR3;
    public Transform CatR4;
    public Transform CatR5;
    public Transform CatR6;
    public Transform CatUP1;
    public Transform CatUP2;
    public Transform CatUP3;
    public Transform CatUP4;
    public Transform CatUP5;
    public Transform CatUP6;
    public Transform CatDOWN1;
    public Transform CatDOWN2;
    public Transform CatDOWN3;
    public Transform CatDOWN4;
    public Transform CatDOWN5;
    public Transform CatDOWN6;

    public float mySpeed;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * mySpeed);
        shotNumberText.text = GameManager.dogTurn + "Nombre de tire:" + " "+shotNumber.ToString() +" "+ dice.ToString();
    }
    public void Fire(int number, string position, string sens)
    {
        if (GameManager.dogTurn == false)
        {
            if (sens == "Left")
            {
                if (position == "Column")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP1.transform.position.x, DogUP1.transform.position.y, DogUP1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP2.transform.position.x, DogUP2.transform.position.y, DogUP2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP3.transform.position.x, DogUP3.transform.position.y, DogUP3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 4)
                    {
                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP4.transform.position.x, DogUP4.transform.position.y, DogUP4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP5.transform.position.x, DogUP5.transform.position.y, DogUP5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogUP6.transform.position.x, DogUP6.transform.position.y, DogUP6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;

                    }

                }

                if (position == "Line")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL1.transform.position.x, DogL1.transform.position.y, DogL1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL2.transform.position.x, DogL2.transform.position.y, DogL2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL3.transform.position.x, DogL3.transform.position.y, DogL3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL4.transform.position.x, DogL4.transform.position.y, DogL4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL5.transform.position.x, DogL5.transform.position.y, DogL5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogL6.transform.position.x, DogL6.transform.position.y, DogL6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }

                }
            }
            if (sens == "Right")
            {


                if (position == "Column")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN1.transform.position.x, DogDOWN1.transform.position.y, DogDOWN1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN2.transform.position.x, DogDOWN2.transform.position.y, DogDOWN2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN3.transform.position.x, DogDOWN3.transform.position.y, DogDOWN3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN4.transform.position.x, DogDOWN4.transform.position.y, DogDOWN4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN5.transform.position.x, DogDOWN5.transform.position.y, DogDOWN5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogDOWN6.transform.position.x, DogDOWN6.transform.position.y, DogDOWN6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }

                }

                if (position == "Line")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR1.transform.position.x, DogR1.transform.position.y, DogR1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR2.transform.position.x, DogR2.transform.position.y, DogR2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR3.transform.position.x, DogR3.transform.position.y, DogR3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR4.transform.position.x, DogR4.transform.position.y, DogR4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR5.transform.position.x, DogR5.transform.position.y, DogR5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(DogR6.transform.position.x, DogR6.transform.position.y, DogR6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                }
            }
        }
        else
        {
            if (sens == "Left")
            {
                if (position == "Column")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP1.transform.position.x, CatUP1.transform.position.y, CatUP1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP2.transform.position.x, CatUP2.transform.position.y, CatUP2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP3.transform.position.x, CatUP3.transform.position.y, CatUP3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 4)
                    {
                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP4.transform.position.x, CatUP4.transform.position.y, CatUP4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP5.transform.position.x, CatUP5.transform.position.y, CatUP5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatUP6.transform.position.x, CatUP6.transform.position.y, CatUP6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * mySpeed;

                    }

                }

                if (position == "Line")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL1.transform.position.x, CatL1.transform.position.y, CatL1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL2.transform.position.x, CatL2.transform.position.y, CatL2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL3.transform.position.x, CatL3.transform.position.y, CatL3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL4.transform.position.x, CatL4.transform.position.y, CatL4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL5.transform.position.x, CatL5.transform.position.y, CatL5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatL6.transform.position.x, CatL6.transform.position.y, CatL6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.right * mySpeed;
                    }

                }
            }
            if (sens == "Right")
            {


                if (position == "Column")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN1.transform.position.x, CatDOWN1.transform.position.y, CatDOWN1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN2.transform.position.x, CatDOWN2.transform.position.y, CatDOWN2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN3.transform.position.x, CatDOWN3.transform.position.y, CatDOWN3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN4.transform.position.x, CatDOWN4.transform.position.y, CatDOWN4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN5.transform.position.x, CatDOWN5.transform.position.y, CatDOWN5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatDOWN6.transform.position.x, CatDOWN6.transform.position.y, CatDOWN6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.back * mySpeed;
                    }

                }

                if (position == "Line")
                {
                    if (number == 1)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR1.transform.position.x, CatR1.transform.position.y, CatR1.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;

                    }
                    if (number == 2)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR2.transform.position.x, CatR2.transform.position.y, CatR2.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 3)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR3.transform.position.x, CatR3.transform.position.y, CatR3.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 4)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR4.transform.position.x, CatR4.transform.position.y, CatR4.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 5)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR5.transform.position.x, CatR5.transform.position.y, CatR5.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                    if (number == 6)
                    {

                        GameObject bullet = Instantiate(projectilPrefab, new Vector3(CatR6.transform.position.x, CatR6.transform.position.y, CatR6.transform.position.z), this.transform.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * mySpeed;
                    }
                }
            }
           
        }
        shotNumber -= 1;
        Reload();
    }
    void Reload()
    {
        if (shotNumber == 0 && round == 0)
        {
            if(GameManager.dogTurn == false )
            {
               
                round = 1;
                cameraManager.SwitchCam("DogShipCam");
                StartFight(GameManager.maxDogGun);
                GameManager.dogTurn = true;
                
            }
            else if (GameManager.dogTurn == true )
            {
                
                round = 1;
                cameraManager.SwitchCam("CatShipCam");
                StartFight(GameManager.maxCatGun);
                GameManager.dogTurn = false;
                
            }

        }
        else if(shotNumber > 0)
        {
            StartFight(shotNumber);
        }
        else
        {
            gameManager.ReceiveMessage("Restart");

        }
    }
}
