using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    Grid myGrid;
    private void Start()
    {
        myGrid = GameObject.Find("Grid").GetComponent<Grid>();
    }
    private void OnMouseOver()
    {
        this.GetComponent<Renderer>().material.color = Color.yellow;
    }
    private void OnMouseExit()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseUp()
    {
        GameObject go = Instantiate(myGrid.ironPrefab, this.transform.position, Quaternion.identity);
        go.name = "Ressources" + gameObject.name;
    }

}
