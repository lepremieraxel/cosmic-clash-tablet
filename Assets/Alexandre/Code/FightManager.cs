using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{


    public Transform L1;
    public Transform L2;
    public Transform L3;
    public Transform L4;
    public Transform L5;
    public Transform L6;
    public Transform R1;
    public Transform R2;
    public Transform R3;
    public Transform R4;
    public Transform R5;
    public Transform R6;
    public Transform UP1;
    public Transform UP2;
    public Transform UP3;
    public Transform UP4;
    public Transform UP5;
    public Transform UP6;
    public Transform DOWN1;
    public Transform DOWN2;
    public Transform DOWN3;
    public Transform DOWN4;
    public Transform DOWN5;
    public Transform DOWN6;

    public GameObject projectilPrefab;

    private float mySpeed;
    private void Awake()
    {
        this.transform.position = new Vector3(-525, Random.Range(-295, 295), transform.position.z);
        mySpeed = Random.Range(-190, -240);
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * mySpeed);
    }
    public void Attack(int number, string position)
    {
        if (position == "UP")
        {
            if (number == 1)
            {
                
                Instantiate(projectilPrefab, new Vector3(UP1.transform.position.x, UP1.transform.position.y, UP1.transform.position.z), this.transform.rotation);
            }
            if (number == 2)
            {
               
                Instantiate(projectilPrefab, new Vector3(UP2.transform.position.x, UP2.transform.position.y, UP2.transform.position.z), this.transform.rotation);
            }
            if (number == 3)
            {

                Instantiate(projectilPrefab, new Vector3(UP3.transform.position.x, UP3.transform.position.y, UP3.transform.position.z), this.transform.rotation);
            }
            if (number == 4)
            {

                Instantiate(projectilPrefab, new Vector3(UP4.transform.position.x, UP4.transform.position.y, UP4.transform.position.z), this.transform.rotation);
            }
            if (number == 2)
            {

                Instantiate(projectilPrefab, new Vector3(UP2.transform.position.x, UP2.transform.position.y, UP2.transform.position.z), this.transform.rotation);
            }
            if (number == 2)
            {

                Instantiate(projectilPrefab, new Vector3(UP2.transform.position.x, UP2.transform.position.y, UP2.transform.position.z), this.transform.rotation);
            }
        }
    }
}
