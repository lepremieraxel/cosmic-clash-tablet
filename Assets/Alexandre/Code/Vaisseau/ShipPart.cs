using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : MonoBehaviour
{
    private void Start()
    {
        if(this.tag == "GunCube")
        {
            if(GameManager.dogTurn == true)
            {
                GameManager.maxDogGun += 1;
            }
            else
            {
                GameManager.maxCatGun += 1;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            if(this.tag == "CoreCube")
            {
                Destroy(other.gameObject);
                //fin de party

            }
            else if(this.tag == "GunCube")
            {
                if (GameManager.dogTurn == true)
                {
                    GameManager.maxDogGun -= 1;
                }
                else
                {
                    GameManager.maxCatGun -= 1;
                }
            }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            
        }
    }
}
