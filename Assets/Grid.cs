using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject newRessourcePrefab;

    public GameObject gridCellPrefab;



    void Start()
    {
        
       for(int i = 1; i < 7; i++)
        {
                   for (int j = 1; j < 7; j++)
            {
                GameObject go = Instantiate(gridCellPrefab, new Vector3(this.transform.position.x + i, 0, this.transform.position.z+j), Quaternion.Euler(90, 0, 0));
                go.transform.parent = transform;
                go.name = i + "-" + j;
                go.name = i + "-" + j;
            }
        }
    }

    public void ChangeRessources(GameObject newRessource)
    {
       newRessourcePrefab = newRessource;
    }


}
