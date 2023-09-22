using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject camDogTurn;
    public GameObject camCatTurn;
    public GameObject camDogShip;
    public GameObject camCatShip;
    private void Start()
    {
        camDogTurn.SetActive(true);
        camCatTurn.SetActive(false);
        camDogShip.SetActive(false);
        camCatShip.SetActive(false);
    }
    public void SwitchCam(string camera)
    {
        if (camera == "DogTurnCam")
        {

            camDogTurn.SetActive(true);
            camCatTurn.SetActive(false);
            camDogShip.SetActive(false);
            camCatShip.SetActive(false);
        }
        if (camera == "CatTurnCam")
        {
            camDogTurn.SetActive(false);
            camCatTurn.SetActive(true);
            camDogShip.SetActive(false);
            camCatShip.SetActive(false);
        }
        if (camera == "DogShipCam")
        {
            Debug.Log("CaMARCHE");
            camDogTurn.SetActive(false);
            camCatTurn.SetActive(false);
            camDogShip.SetActive(true);
            camCatShip.SetActive(false);
        }
        if (camera == "CatShipCam")
        {
            camDogTurn.SetActive(false);
            camCatTurn.SetActive(false);
            camDogShip.SetActive(false);
            camCatShip.SetActive(true);
        }
    }

}
