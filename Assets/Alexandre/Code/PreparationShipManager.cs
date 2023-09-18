using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparationShipManager : MonoBehaviour
{
    private int currentIron;
    private int currentShield;
    private int currentGun;

    private void Awake()
    {
        currentIron = 3;
        currentShield = 1;
        currentGun = 1;
    }
    void Update()
    {
        if (currentIron >= 1|| currentShield >= 1 || currentGun >= 1)
        {
            //bool NeedCraft = true; //pour dire au jeu qu'on est obligé de mettre nos ressources
            //ouvrir grille de création de vaisseau
        }
    }
    void AddRessource(int iron, int shield, int gun)
    {
        currentGun = gun;

        currentIron = iron;

        currentShield = shield;
    }
}
