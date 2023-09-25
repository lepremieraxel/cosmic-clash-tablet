using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject canvaDebut;
    public GameObject canvaD4;
    public GameObject canvaCard;
    public GameObject canvaShipManager;
    public GameObject canvaFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void SwitchCanvas(string canvas)
    {
        if ( canvas == "canvasDebut")
        {
            canvaDebut.SetActive(true);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
        }
        if (canvas == "canvasD4")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(true);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
        }
        if (canvas == "canvasCard")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(true);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
        }
        if (canvas == "canvasShipManager")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(true);
            canvaFire.SetActive(false);
        }
        if (canvas == "canvasFire")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(true);
        }
    }
}
