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
    public GameObject canvaChoseLineOrColumn;
    public GameObject canvaChoseRightOrLeft;
    // Start is called before the first frame update

public void SwitchCanvas(string canvas)
    {
        if ( canvas == "canvasDebut")
        {
            canvaDebut.SetActive(true);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasD4")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(true);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasCard")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(true);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasShipManager")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(true);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasFire")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(true);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasChoseLineOrColumn")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(true);
            canvaChoseRightOrLeft.SetActive(false);
        }
        if (canvas == "canvasChoseRightOrLeft")
        {
            canvaDebut.SetActive(false);
            canvaD4.SetActive(false);
            canvaCard.SetActive(false);
            canvaShipManager.SetActive(false);
            canvaFire.SetActive(false);
            canvaChoseLineOrColumn.SetActive(false);
            canvaChoseRightOrLeft.SetActive(true);
        }

    }
}
