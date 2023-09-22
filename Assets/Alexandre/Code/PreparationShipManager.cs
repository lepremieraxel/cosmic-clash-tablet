using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparationShipManager : MonoBehaviour
{
    public int currentIron;
    public int currentShield;
    public int currentGun;
    public int currentCore;

    public bool needCraft;
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
    
}
