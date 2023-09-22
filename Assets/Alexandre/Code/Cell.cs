using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool iCanIronAndGun;
    Grid myGrid;
    PreparationShipManager currentIronBloc;
    PreparationShipManager currentShieldBloc;
    PreparationShipManager currentGunBloc;
    PreparationShipManager currentCoreBloc;

    private void Update()
    {

    }

    private void Start()
    {
        myGrid = GameObject.Find("DogGrid").GetComponent<Grid>();
        currentIronBloc= GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
        currentShieldBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
        currentGunBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
        currentCoreBloc = GameObject.Find("DogManager").GetComponent<PreparationShipManager>();
    }
    private void OnMouseOver()
    {
        if ((myGrid.newRessourcePrefab.name == "IronCube" && currentIronBloc.currentIron == 0)||(myGrid.newRessourcePrefab.name == "GunCube" && currentGunBloc.currentGun == 0) || (myGrid.newRessourcePrefab.name == "ShieldCube" && currentShieldBloc.currentShield == 0) || (myGrid.newRessourcePrefab.name == "CoreCube" && currentCoreBloc.currentCore == 0))
        {
            this.GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (myGrid.newRessourcePrefab.name == "IronCube" || myGrid.newRessourcePrefab.name == "GunCube")
        {
            if(iCanIronAndGun == true)
            {
                this.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                this.GetComponent<Renderer>().material.color = Color.red;
            }
            
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.yellow;
        }

    }
    private void OnMouseExit()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnMouseUp()
    {
        if (myGrid.newRessourcePrefab.name == "IronCube" || myGrid.newRessourcePrefab.name == "GunCube" )
        {
            if (iCanIronAndGun == true)
            {
                if (myGrid.newRessourcePrefab.name == "IronCube" && currentIronBloc.currentIron >= 1)
                {
                    PlaceRessource();
                    currentIronBloc.currentIron = currentIronBloc.currentIron - 1;
                }
                if (myGrid.newRessourcePrefab.name == "GunCube" && currentGunBloc.currentGun >= 1)
                {
                    PlaceRessource();
                    currentGunBloc.currentGun = currentGunBloc.currentGun - 1;
                }
            }
        }
        else
        {
            if (myGrid.newRessourcePrefab.name == "ShieldCube" && currentShieldBloc.currentShield >= 1)
            {
                PlaceRessource();
                currentShieldBloc.currentShield = currentShieldBloc.currentShield - 1;
            }
            if (myGrid.newRessourcePrefab.name == "CoreCube" && currentCoreBloc.currentCore == 1)
            {
                PlaceRessource();
                currentCoreBloc.currentCore = currentCoreBloc.currentCore - 1;
            }
        }
        
    }
    void PlaceRessource()
    {
        GameObject go = Instantiate(myGrid.newRessourcePrefab, this.transform.position, Quaternion.identity);
        go.transform.SetParent(this.transform);
        this.gameObject.tag = myGrid.newRessourcePrefab.name;
        go.name = "Ressources" + gameObject.name;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("IronCube")|| other.CompareTag("CoreCube") || other.CompareTag("GunCube"))
        {
            iCanIronAndGun = true;
        }      
    }

    public void OnTriggerExit(Collider other)
    {
        iCanIronAndGun = false;
    }
}
