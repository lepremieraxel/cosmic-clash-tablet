using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparationShipManager : MonoBehaviour
{
    [SerializeField] private int currentIron;
    [SerializeField] private int currentShield;
    [SerializeField] private int currentGun;

    private void Awake()
    {
        currentIron = 0;
        currentShield = 0;
        currentGun = 0;
    }
    void Update()
    {
        if (currentIron >= 1|| currentShield >= 1 || currentGun >= 1)
        {
            
            //bool NeedCraft = true; //pour dire au jeu qu'on est obligé de mettre nos ressources
            //ouvrir grille de création de vaisseau
        }
    }
    public void AddRessource(int iron, int shield, int gun)
    {
        currentGun += gun;
       
        currentIron += iron;

        currentShield += shield;
    }
    
}
