using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool iCanIronAndGun;
    Grid myGrid;
    private void Update()
    {
        if (this.gameObject.tag == "IronCube")
        {

        }
    }

    private void Start()
    {
        myGrid = GameObject.Find("Grid").GetComponent<Grid>();
    }
    private void OnMouseOver()
    {
        if (myGrid.newRessourcePrefab.name == "IronCube" || myGrid.newRessourcePrefab.name == "GunCube")
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
                PlaceRessource();
            }
            
        }
        else
        {
            PlaceRessource();
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
