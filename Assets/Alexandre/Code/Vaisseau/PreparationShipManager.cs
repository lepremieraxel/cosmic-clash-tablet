using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreparationShipManager : MonoBehaviour
{
    public int currentIron;
    public int currentShield;
    public int currentGun;
    public int currentCore;

    public Text ironText;
    public Text shieldText;
    public Text gunText;
    public Text coreText;
    public bool needCraft;
    public GameObject canvasValidation;
    private void Awake()
    {
        currentIron = 3;
        currentShield = 1;
        currentGun = 1;
        currentCore = 1;
    }
    public void AddRessource(int iron, int shield, int gun)
    {
        currentGun += gun;
        
        currentIron += iron;

        currentShield += shield;
    }
    private void Update()
    {
        ironText.text = currentIron.ToString();
        shieldText.text = currentShield.ToString();
        gunText.text = currentGun.ToString();
        coreText.text = currentCore.ToString();

        if(currentIron == 0 && currentGun ==0 && currentCore == 0 && currentShield == 0)
        {
            canvasValidation.SetActive(true);
        }
        else
        {
            canvasValidation.SetActive(false);
        }
    }
}
